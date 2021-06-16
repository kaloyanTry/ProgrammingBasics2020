using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBed = double.Parse(Console.ReadLine());
            double priceToilet = double.Parse(Console.ReadLine());

            double totalCost = 0.0;

            double priceFood = priceToilet + priceToilet * 0.25;
            double priceToys = priceFood - priceFood * 0.5;
            double priceVet = priceToys + priceToys * 0.1;
         
            totalCost = priceFood + priceToilet + priceVet + priceToys;
            
            double extra = totalCost * 0.05;
            
            totalCost = priceBed + 12 * totalCost + 12 * extra;

            Console.WriteLine($"{totalCost:F2} lv.");
        }
    }
}
