
using Chinook.Contracts.Persistence;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Models.Persistence
{
    [EntityInfo(FileName = "Album.csv", Seperator = ';', HasHeader = true)]
    internal class Album : IdentityObject, IAlbum
    {
        [PropertyInfo(OrderPosition = 1)]
        public string Title { get; set; }
        [PropertyInfo(OrderPosition = 2)]
        public int ArtistId { get; set; }
    }
}