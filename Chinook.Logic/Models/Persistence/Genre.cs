
using Chinook.Contracts.Persistence;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Models.Persistence
{
    [EntityInfo(FileName = "Genre.csv", Seperator = ';', HasHeader = true)]
    internal class Genre : IdentityObject, IGenre
    {
        [PropertyInfo(OrderPosition = 1)]
        public string Name { get; set; }
    }
}