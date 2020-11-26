using CsvMapper.Logic.Attributes;

namespace CsvMapper.Logic.Models
{
    [EntityInfo(FileName = "PlaylistTrack.csv", Seperator = ';', HasHeader = true)]
    public class PlaylistTrack : ModelObject
    {
        [PropertyInfo(OrderPosition = 1)]
        public int PlaylistId { get; set; }
    }
}