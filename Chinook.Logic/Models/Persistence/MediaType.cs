using Chinook.Contracts.Persistence;
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Models.Persistence
{
    [EntityInfo(FileName = "MediaType.csv", Seperator = ';', HasHeader = true)]
    internal class MediaType : IdentityObject, IMediaType
    {
        [PropertyInfo(OrderPosition = 1)]
        public int MediaTypeId { get; set; }
    }
}