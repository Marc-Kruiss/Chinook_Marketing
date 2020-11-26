using System;
using System.Collections.Generic;
using System.Text;

namespace CsvMapper.Logic.Attributes
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =false)]
    public class EntityInfoAttribute:System.Attribute
    {
        public string FileName { get; set; }
        public char Seperator { get; set; } = ';';
        public bool HasHeader { get; set; } = false;
    }
}
