using System;
using System.IO;

namespace _3._2NestedStatements
{
    class SkiResort
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();

            double priceRoom = 18.0;
            double priceApartment = 25.0;
            double pricePresident = 35.0;
            double priceTotal = 0.0;

            if (days >= 1) days = days - 1;
            else days = days;

            if (room == "room for one person")
            {
                if (days < 10)
                {
                    priceTotal = priceRoom * days;
                }
                else if (days > 10 && days < 15)
                {
                    priceTotal = priceRoom * days;
                }
                else if (days > 15)
                {
                    priceTotal = priceRoom * days;
                }
            }
            else if (room == "apartment")
            {
                if (days < 10)
                {
                    priceTotal = priceApartment * days;
                    priceTotal = priceTotal - (priceTotal * 0.3);
                }
                else if (days > 10 && days < 15)
                {
                    priceTotal = priceApartment * days;
                    priceTotal = priceTotal - (priceTotal * 0.35);
                }
                else if (days > 15)
                {
                    priceTotal = priceApartment * days;
                    priceTotal = priceTotal - (priceTotal * 0.5);
                }
            }
            else if (room == "president apartment")
            {
                if (days < 10)
                {
                    priceTotal = pricePresident * days;
                    priceTotal = priceTotal - (priceTotal * 0.1);
                }
                else if (days > 10 && days < 15)
                {
                    priceTotal = pricePresident * days;
                    priceTotal = priceTotal - (priceTotal * 0.15);
                }
                else if (days > 15)
                {
                    priceTotal = pricePresident * days;
                    priceTotal = priceTotal - (priceTotal * 0.2);
                }
            }

            if (feedback == "positive")
            {
                priceTotal = priceTotal + (priceTotal * 0.25);
            }
            else if (feedback == "negative")
            {
                priceTotal = priceTotal - (priceTotal * 0.1);
            }
            Console.WriteLine($"{priceTotal:F2}");
        }
    }
}
