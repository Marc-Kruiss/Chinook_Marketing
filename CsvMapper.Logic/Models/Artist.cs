using CsvMapper.Logic.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsvMapper.Logic.Models
{
    [EntityInfo(FileName ="Artist.csv",Seperator =';',HasHeader =true)]
    public class Artist
    {
        [PropertyInfo(OrderPosition =1)]
        public string Name { get; set; }

    }
}
