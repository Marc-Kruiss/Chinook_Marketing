
using CsvMapper.Logic.Attributes;

namespace CsvMapper.Logic.Models
{
    [EntityInfo(FileName = "Genre.csv", Seperator = ';', HasHeader = true)]
    public class Genre : ModelObject
    {
        [PropertyInfo(OrderPosition = 1)]
        public string Name { get; set; }
    }
}