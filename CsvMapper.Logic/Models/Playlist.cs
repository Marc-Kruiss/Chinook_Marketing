using CsvMapper.Logic.Attributes;

namespace CsvMapper.Logic.Models
{
    [EntityInfo(FileName = "Playlist.csv", Seperator = ';', HasHeader = true)]
    public class Playlist : ModelObject
    {
        [PropertyInfo(OrderPosition = 1)]
        public int PlaylistId { get; set; }
    }
}