using System;
using System.Diagnostics;

namespace _6._2.TicketsCinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string command = "";
            int totalStandart = 0;
            int totalStudent = 0;
            int totalKid = 0;
            double totalAll = 0;

            while (command != "Finish")
            {
                command = Console.ReadLine();

                int counterStandard = 0;
                int counterStudent = 0;
                int counterKid = 0;
                if (command == "Finish") break;

                double emptyPlaces = double.Parse(Console.ReadLine());
                for (int i = 0; i < emptyPlaces; i++)
                {
                    string movie = Console.ReadLine();
                    if (movie == "standard") counterStandard++;
                    if (movie == "student") counterStudent++;
                    if (movie == "kid") counterKid++;
                    if (movie == "End") break;
                }

                totalStandart += counterStandard;
                totalStudent += counterStudent;
                totalKid += counterKid;

                Console.WriteLine($"{command} - {(((counterKid + counterStudent + counterStandard) / emptyPlaces) * 100):F2}% full.");
            }

            totalAll = totalKid + totalStandart + totalStudent;
            Console.WriteLine($"Total tickets: {totalAll}");
            Console.WriteLine($"{((totalStudent / totalAll) * 100):F2}% student tickets.");
            Console.WriteLine($"{((totalStandart / totalAll) * 100):F2}% standard tickets.");
            Console.WriteLine($"{((totalKid / totalAll) * 100):F2}% kids tickets.");
        }
    }
}