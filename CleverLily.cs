using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace _4._2.ForLoops
{
    class CleverLily
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWash = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());

            double sum = 0;
            double money = 10;
            int toys = 0;
            double sumToys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum += money;
                    money += 10;
                    sum -= 1;
                }
                else toys++;
            }
            sumToys = priceToys * toys;
            sum += sumToys;

            if (sum >= priceWash) Console.WriteLine($"Yes! {(sum - priceWash):F2}");
            else Console.WriteLine($"No! {(priceWash - sum):F2}");
        }
    }
}