using System;

namespace SoftUni
{
    class Greening
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double price = meters * 7.61;
            double discount = price * 18 / 100;

            Console.WriteLine($"The final price is: {price - discount} lv.");
            Console.WriteLine($"The dicount is {discount} lv.");

        }
    }
}
