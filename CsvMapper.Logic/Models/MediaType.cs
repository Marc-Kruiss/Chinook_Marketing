using CsvMapper.Logic.Attributes;

namespace CsvMapper.Logic.Models
{
    [EntityInfo(FileName = "MediaType.csv", Seperator = ';', HasHeader = true)]
    public class MediaType : ModelObject
    {
        [PropertyInfo(OrderPosition = 1)]
        public int MediaTypeId { get; set; }
    }
}