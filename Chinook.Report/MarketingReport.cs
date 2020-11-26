using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Report
{
    class MarketingReport
    {
        public static IEnumerable<Contracts.Report.IArtistStatistic> GetArtistStatistic()
        {
            var albums = Logic.Factory.GetAllAlbums();
            var artists = Logic.Factory.GetAllArtists();

            // Abfrage

            return null;
        }
    }
}
