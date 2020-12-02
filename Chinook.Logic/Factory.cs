using CsvMapper.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic
{
    public class Factory
    {
        public static IEnumerable<Contracts.Persistence.IGenre> GetAllGenres()
        {
            var result = CsvHelper.Read<Models.Persistence.Genre>();
            return result;
        }
        public static IEnumerable<Contracts.Persistence.IAlbum> GetAllAlbums()
        {
            var result = CsvHelper.Read<Models.Persistence.Album>();
            return result;
        }
        public static IEnumerable<Contracts.Persistence.IArtist> GetAllArtists()
        {
            var result = CsvHelper.Read<Models.Persistence.Artist>();
            return result;
        }
        public static IEnumerable<Contracts.Persistence.ICustomer> GetAllCustomers()
        {
            var result = CsvHelper.Read<Models.Persistence.Customer>();
            return result;
        }
        public static IEnumerable<Contracts.Persistence.IEmployee> GetAllEmployees()
        {
            var result = CsvHelper.Read<Models.Persistence.Employee>();
            return result;
        }
        public static IEnumerable<Contracts.Persistence.IInvoice> GetAllInvoices()
        {
            var result = CsvHelper.Read<Models.Persistence.Invoice>();
            return result;
        }
        public static IEnumerable<Contracts.Persistence.IInvoiceLine> GetAllInvoiceLines()
        {
            var result = CsvHelper.Read<Models.Persistence.InvoiceLine>();
            return result;
        }
        public static IEnumerable<Contracts.Persistence.IMediaType> GetAllMediaTypes()
        {
            var result = CsvHelper.Read<Models.Persistence.MediaType>();
            return result;
        }
        public static IEnumerable<Contracts.Persistence.IPlaylist> GetAllPlaylists()
        {
            var result = CsvHelper.Read<Models.Persistence.Playlist>();
            return result;
        }
        public static IEnumerable<Contracts.Persistence.IPlaylistTrack> GetAllPlaylistTracks()
        {
            var result = CsvHelper.Read<Models.Persistence.PlaylistTrack>();
            return result;
        }
        public static IEnumerable<Contracts.Persistence.ITrack> GetAllTracks()
        {
            var result = CsvHelper.Read<Models.Persistence.Track>();
            return result;
        }
    }
}
