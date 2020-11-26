using System;
using System.Collections.Generic;
using System.Text;

namespace CsvMapper.Logic.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple =false)]
    public class PropertyInfoAttribute:System.Attribute
    {
        public bool IsRequired { get; set; } = false;
        public int MaxLength { get; set; } = -1;
        public int OrderPosition { get; set; } = -1;
        public string DefaultValue { get; set; } = string.Empty;
        public bool Readonly { get; set; } = false;
        public bool Calculation { get; set; } = false;
        public bool NotMapped { get; set; } = false;
    }
}
