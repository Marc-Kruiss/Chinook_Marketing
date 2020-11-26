using Chinook.Contracts.Persistence;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Models.Persistence
{
    [EntityInfo(FileName = "Playlist.csv", Seperator = ';', HasHeader = true)]
    internal class Playlist : IdentityObject, IPlaylist
    {
        [PropertyInfo(OrderPosition = 1)]
        public int PlaylistId { get; set; }
    }
}