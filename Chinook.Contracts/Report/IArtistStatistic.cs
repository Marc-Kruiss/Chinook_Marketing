using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Report
{
    public interface IArtistStatistic
    {
        public string Name { get;}
        public int AlbumCount { get;}
    }
}
