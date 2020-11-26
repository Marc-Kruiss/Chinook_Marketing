using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Persistence
{
    public interface IAlbum:IIdentifiable
    {
        public string Title { get; set; }
        public int ArtistId { get; set; }
    }
}
