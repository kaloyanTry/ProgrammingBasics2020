using System;

namespace _4._3.Salary
{
    class Salary
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= tabs; i++)
            {
                string sites = Console.ReadLine();

                if (sites == "Facebook") salary = salary - 150;

                else if (sites == "Instagram") salary = salary - 100;

                else if (sites == "Reddit") salary = salary - 50;

                else salary = salary - 0;

                if (salary <= 0) break;
            }

            if (salary > 0) Console.WriteLine(salary);

            else Console.WriteLine("You have lost your salary.");
        }
    }
}
