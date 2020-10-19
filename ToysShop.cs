using System;

namespace _2._2.Conditions
{
    class ToysShop
    {
        static void Main(string[] args)
        {

            double priceTrip = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minuns = int.Parse(Console.ReadLine());
            int truks = int.Parse(Console.ReadLine());

            double sum = puzzels * 2.6 + dolls * 3 + bears * 4.1 + minuns * 8.2 + truks * 2;

            if ((dolls + puzzels + bears + minuns + truks) >= 50)
            {
                sum = sum - sum * 0.25;
            }

            sum = sum - sum * 0.1;

            if (sum >= priceTrip)
            {
                Console.WriteLine($"Yes! {(sum - priceTrip):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(priceTrip - sum):F2} lv needed.");
            }
        }
    }
}
