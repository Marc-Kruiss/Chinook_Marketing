/*
 *  Marc Kruiß
 *  4BHIF
 *  18.11.2020
 * 
 */

using CsvMapper.Logic;
using System.Linq;
using System;
using System.Collections.Generic;
using Chinook.Logic;

namespace Chinook.ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Requests.GetAlbumStats();
            Requests.GetCustomerStats();
            Requests.GetGenreSellStats();
            Requests.GetQuantitiyStats();
            Requests.GetSellStats();
            var result = Requests.GetTrackDurationStats();





            // Ausgabe
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*           Chinook-Marketing                             *");
            Console.WriteLine("*           Marc Kruiß                                    *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine();

            Console.WriteLine("Track-Zeit Auswertung\n" +
                "Tack/Titel\n" +
                $"Track with hightest Duration: {result.track_with_highest_duration.Name}\t\t\t{result.track_with_highest_duration.Milliseconds/1000}\n"+
                $"Track with shortest Duration: {result.track_with_lowest_duration.Name}\t\t\t{result.track_with_lowest_duration.Milliseconds / 1000}\n"+
                $"Approximately Duration: \t\t\t\t{result.approximately_track_duration_in_milliseconds / 1000}");
            Console.WriteLine();

        }
    }
}
