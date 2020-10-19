using System;

namespace Excursion
{
    class ExcursionsSales
    {
        static void Main(string[] args)
        {
            int numSea = int.Parse(Console.ReadLine());
            int numMountain = int.Parse(Console.ReadLine());

            double priceSea = 680.0;
            double priceMountain = 499.0;
            double priceSeaTotal = 0.0;
            double priceMountainTotal = 0.0;

            string command = "";

            while (true)
            {
                command = Console.ReadLine();
                if (command == "Stop") break;

                if (command == "sea")
                {
                    priceSeaTotal += priceSea;
                    numSea--;
                    if (numSea <= 0) priceSea = 0;
                }
                else if (command == "mountain")
                {
                    priceMountainTotal += priceMountain;
                    numMountain--;
                    if (numMountain <= 0) priceMountain = 0;
                }

                if (numSea <= 0 && numMountain <= 0) break;
            }

            if (numSea <= 0 && numMountain <= 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {priceMountainTotal + priceSeaTotal} leva.");
          
        }
    }
}
