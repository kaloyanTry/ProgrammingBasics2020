using System;

namespace _6._2.Travels
{
    class TravelsAni
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string country = Console.ReadLine();
                if (country == "End") break;

                double budget = double.Parse(Console.ReadLine());
                double courentBudget = 0;

                while (courentBudget < budget)
                {
                    double sum = double.Parse(Console.ReadLine());
                    courentBudget += sum;
                }

                Console.WriteLine($"Going to {country}!");
            }
        }
    }
}
