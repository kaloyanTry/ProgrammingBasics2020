using System;

namespace _5._3.WhileEx
{
    class HolidayJessy
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double realMoney = double.Parse(Console.ReadLine());
            int counterDays = 0;
            int counterSpend = 0;

            while (realMoney < neededMoney && counterSpend < 5)
            {
                string spendSave = Console.ReadLine();
                double sumSpendSave = double.Parse(Console.ReadLine());
                counterDays++;

                if (spendSave == "spend")
                {
                    realMoney -= sumSpendSave;
                    if (realMoney <=0)  realMoney = 0;
                    counterSpend++;
                }

                if (spendSave == "save")
                {
                    realMoney += sumSpendSave;
                    counterSpend = 0;
                }
            }
            if (counterSpend == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(counterDays);
            }

            if (realMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {counterDays} days.");
            }
        }
    }
}
