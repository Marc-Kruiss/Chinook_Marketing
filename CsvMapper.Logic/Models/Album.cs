
using CsvMapper.Logic.Attributes;

namespace CsvMapper.Logic.Models
{
    [EntityInfo(FileName = "Album.csv", Seperator = ';', HasHeader = true)]
    public class Album : ModelObject
    {
        [PropertyInfo(OrderPosition = 1)]
        public string Title { get; set; }
        [PropertyInfo(OrderPosition = 2)]
        public int AlbumId { get; set; }
    }
}