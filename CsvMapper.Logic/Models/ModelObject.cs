using CsvMapper.Logic.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsvMapper.Logic.Models
{
    public class ModelObject
    {
        [PropertyInfo(OrderPosition =0, IsRequired =true)]
        public int Id { get; set; }
    }
}
