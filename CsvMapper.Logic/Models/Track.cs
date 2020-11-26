using CsvMapper.Logic.Attributes;
using System;

namespace CsvMapper.Logic.Models
{
    [EntityInfo(FileName = "Track.csv", Seperator = ';', HasHeader = true)]
    public class Track : ModelObject, IComparable
    {
        // TrackId;Name;AlbumId;MediaTypeId;GenreId;Composer;Milliseconds;Bytes;UnitPrice

        [PropertyInfo(OrderPosition = 1)]
        public string Name { get; set; }
        [PropertyInfo(OrderPosition = 2)]
        public int AlbumId { get; set; }
        [PropertyInfo(OrderPosition = 3)]
        public int MediaTypeId { get; set; }
        [PropertyInfo(OrderPosition = 4)]
        public int GenreId { get; set; }
        [PropertyInfo(OrderPosition = 5)]
        public string Composer { get; set; }
        [PropertyInfo(OrderPosition = 6)]
        public int Milliseconds { get; set; }
        [PropertyInfo(OrderPosition = 7)]
        public int Bytes { get; set; }
        [PropertyInfo(OrderPosition = 8)]
        public double UnitPrice { get; set; }

        public int CompareTo(object obj)
        {
            return Milliseconds.CompareTo(((Track) obj).Milliseconds);
        }
    }
}