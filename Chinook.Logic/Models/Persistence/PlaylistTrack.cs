using Chinook.Contracts.Persistence;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Models.Persistence
{
    [EntityInfo(FileName = "PlaylistTrack.csv", Seperator = ';', HasHeader = true)]
    internal class PlaylistTrack : IdentityObject,IPlaylistTrack
    {
        [PropertyInfo(OrderPosition = 1)]
        public int PlaylistId { get; set; }
    }
}