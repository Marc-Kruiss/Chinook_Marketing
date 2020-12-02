using Chinook.Contracts.Persistence;
using Chinook.Logic.Models.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chinook.Logic
{
    public static class Requests
    {
        public static (IAlbum, IAlbum, double) GetAlbumStats()
        {
            var tracks = Logic.Factory.GetAllTracks();

            // Album Zeit Auswertung
            // Album mit Maximalzeit
            var shortestAlbum = tracks.GroupBy(t => t.AlbumId).Select(s => (s.Key, s.Sum(g => g.Milliseconds))).OrderBy(t => t.Item2).FirstOrDefault();
            // Album mit Minimalzeit
            var longestAlbum = tracks.GroupBy(t => t.AlbumId).Select(s => (s.Key, s.Sum(g => g.Milliseconds))).OrderByDescending(t => t.Item2).FirstOrDefault();
            // Durchschnittliche Zeit
            var approximatelyAlbumDuration = tracks.GroupBy(t => t.AlbumId).Select(s => (s.Key, s.Sum(g => g.Milliseconds))).Average(t => t.Item2);

            var albums = Logic.Factory.GetAllAlbums();
            return (albums.ElementAt(shortestAlbum.Key),albums.ElementAt(longestAlbum.Key), approximatelyAlbumDuration);
        }
        
        public static (int,int) GetQuantitiyStats()
        {
            var invoiceLines = Logic.Factory.GetAllInvoiceLines();
            var tracks = Logic.Factory.GetAllTracks();

            var quantities = invoiceLines.Join(tracks, line => line.Id, track => track.Id, (line, track) => new { TrackName = track.Name, quantity = line.Quantity }).GroupBy(t => t.TrackName).Select(s => (s.Key, s.Sum(g => g.quantity))).OrderByDescending(t => t.Item2);
            var greatestSellQuantity = quantities.Where(t => t.Item2 == quantities.First().Item2).FirstOrDefault();
            var smallestSellQuantity = quantities.Where(t => t.Item2 == quantities.Last().Item2).FirstOrDefault();

            return (greatestSellQuantity.Item2, smallestSellQuantity.Item2);
        }

        public static (double greatestTotal, double smallestTotal) GetSellStats()
        {
            var invoiceLines = Logic.Factory.GetAllInvoiceLines();
            var tracks = Logic.Factory.GetAllTracks();
            // Track Verkauf Auswertung
            var totals = invoiceLines.Join(tracks, line => line.Id, track => track.Id, (line, track) => new { TrackName = track.Name, total = line.Quantity * line.UnitPrice }).GroupBy(t => t.TrackName).Select(s => (s.Key, s.Sum(g => g.total))).OrderByDescending(t => t.Item2);
            var greatestTotal = totals.Where(t => t.Item2 == totals.First().Item2).FirstOrDefault();
            var smallestTotal = totals.Where(t => t.Item2 == totals.Last().Item2).FirstOrDefault();

            return (greatestTotal.Item2, smallestTotal.Item2);
        }

        public static (double richestCustomer, double poorestCustomer) GetCustomerStats()
        {
            var invoices = Logic.Factory.GetAllInvoices();
            var customers = Logic.Factory.GetAllCustomers();
            // Kunden Auswertung
            var customer_Invoice = customers.Join(invoices, customer => customer.Id, invoice => invoice.Customerid, (customer, invoice) => new { customerName = customer.FirstName + " " + customer.LastName, total = invoice.Total }).GroupBy(t => t.customerName).Select(s => (s.Key, s.Sum(g => g.total))).OrderByDescending(t => t.Item2);
            var richestCustomer = customer_Invoice.Where(t => t.Item2 == customer_Invoice.First().Item2).FirstOrDefault();
            var poorestCustomer = customer_Invoice.Where(t => t.Item2 == customer_Invoice.Last().Item2).FirstOrDefault();

            return (richestCustomer.Item2, poorestCustomer.Item2);
        }

        public static (IGenre mostUsedGenre, IGenre lessUsedGenre) GetGenreSellStats()
        {
            var tracks = Logic.Factory.GetAllTracks();
            var genres = Logic.Factory.GetAllGenres();

            // Genre Verkauf Auswertung
            var track_genre = tracks.Join(genres, track => track.GenreId, genre => genre.Id, (track, genre) => new { trackName = track.Name, genre = genre.Name }).GroupBy(t => t.genre).Select(s => (s.Key, s.Count())).OrderByDescending(t => t.Item2);
            var mostUsedGenre = track_genre.Where(t => t.Item2 == track_genre.First().Item2).FirstOrDefault();
            var lessUsedGenre = track_genre.Where(t => t.Item2 == track_genre.Last().Item2).FirstOrDefault();

            
            return (genres.Where(g => g.Name == mostUsedGenre.Key).FirstOrDefault(), genres.Where(g=>g.Name== lessUsedGenre.Key).FirstOrDefault());
        }

        public static (ITrack track_with_highest_duration, ITrack track_with_lowest_duration, double approximately_track_duration_in_milliseconds) GetTrackDurationStats()
        {
            var tracks = Logic.Factory.GetAllTracks();
            // Track Zeit Auswertung
            // Track mit Maximalzeit
            var track_with_highest_duration = tracks.Where(t => t.Milliseconds == tracks.Max(t => t.Milliseconds)).FirstOrDefault();
            // Track mit Minimalzeit
            var track_with_lowest_duration = tracks.Where(t => t.Milliseconds == tracks.Min(t => t.Milliseconds)).FirstOrDefault();
            // Durchschnittliche Spielzeit
            var approximately_track_duration_in_milliseconds = tracks.Sum(t => t.Milliseconds) / tracks.Count();

            return (track_with_highest_duration, track_with_lowest_duration, approximately_track_duration_in_milliseconds);
        }

        

    }
}
