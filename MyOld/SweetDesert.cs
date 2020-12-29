using System;

namespace SweetDesert
{
    class SweetDesert
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            double priceBananas = double.Parse(Console.ReadLine());
            double priceEggs = double.Parse(Console.ReadLine());
            double priceBerries = double.Parse(Console.ReadLine());

            double setOfPortion = (2 * priceBananas) + (4 * priceEggs) + (0.2 * priceBerries);

            int set = 0;

            for (int i = 1; i <= numberOfGuests; i += 6)
            {
                set++;
            }

            double totalPrice = setOfPortion * set;

            if (totalPrice <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalPrice - cash):F2}lv more.");
            }
        }
    }
}
