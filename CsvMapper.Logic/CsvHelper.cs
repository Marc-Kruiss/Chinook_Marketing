using CsvMapper.Logic.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CsvMapper.Logic
{
    public class CsvHelper
    {
        private static string NullLabel => "<NULL>";
        public static void Write<T>(IEnumerable<T> models)
        {
            if (models == null)
                throw new ArgumentException();

            var first = models.FirstOrDefault();
            var lines = new List<string>();

            if (first != null)
            {
                var metaData = GetModelData<T>(first);
                if(metaData.IsDataClass)
                {
                    foreach (var item in models)
                    {
                        
                        var line = CreateCsvLine(item, metaData.Seperator);

                        lines.Add(line);
                    }
                    File.WriteAllLines(metaData.FileName, lines, Encoding.Default);
                }
            }
        }

        private static string CreateCsvLine<T>(T model, char seperator)
        {
            if (model == null)
                throw new ArgumentNullException();

            var result  = new StringBuilder();

            var type = model.GetType();
            var attributes = new List<PropertyInfoAttribute>();

            var exportProps = type.GetProperties()
                .Where(p => p.GetCustomAttribute<PropertyInfoAttribute>() != null)
                .OrderBy(e => e.GetCustomAttribute<PropertyInfoAttribute>().OrderPosition);

            foreach (var item in exportProps)
            {
                if (item.GetCustomAttribute<PropertyInfoAttribute>().NotMapped == false)
                {
                    var value = item.GetValue(model);
                    if (result.Length > 0)
                        result.Append(seperator);

                    if (value != null)
                        result.Append(value.ToString());
                    else
                        result.Append(NullLabel);
                }
            }

            return result.ToString();
        }

        public static IEnumerable<T> Read<T>()where T : new()
        {
            T example = new T();
            var metaData = GetModelData<T>(example);
            var result = new List<T>();

            var type = typeof(T);

            var exportProps = type.GetProperties()
                .Where(p => p.GetCustomAttribute<PropertyInfoAttribute>() != null)
                .OrderBy(e => e.GetCustomAttribute<PropertyInfoAttribute>().OrderPosition);

            var lines = File.ReadAllLines("./Source/"+metaData.FileName, Encoding.Default);
            if (metaData.HasHeader)
            {
                lines = lines.Skip(1).ToArray();
            }
            foreach (string line in lines)
            {
                var information = RemoveNestedSeperators(line,metaData.Seperator).Split(metaData.Seperator);
                var entity = new T();

                foreach (var item in exportProps)
                {

                    var info = item.GetCustomAttribute<PropertyInfoAttribute>();
                    if (info.NotMapped==false)
                    {
                        entity.GetType().GetProperty(item.Name.ToString()).SetValue(entity, Convert.ChangeType(information[info.OrderPosition], item.PropertyType));
                    }
                }
                result.Add(entity);
            }
            
            return result;
        }

        private static (bool IsDataClass,string FileName,char Seperator, bool HasHeader) GetModelData<T>(T model)
        {
            if (model == null)
                throw new ArgumentNullException();

            var type = model.GetType();
            var dca = type.GetCustomAttribute<EntityInfoAttribute>();

            if (dca != null)
                return (true, dca.FileName, dca.Seperator, dca.HasHeader);

            return (false, null, default(char), false);
        }

        private static string RemoveNestedSeperators(string line, char seperator)
        {
            var res = "";
            bool inside = false;
            char other = seperator == ';' ? ',' : ';';

            for (int i = 0; i < line.Length; i++)
            {
                char curr = line[i];
                if (line[i] == '"')
                    inside = !inside;
                if (inside && curr == seperator)
                    curr = other;


                if (curr != '"')
                    res += curr;
            }
            return res;
        }
    }
}
