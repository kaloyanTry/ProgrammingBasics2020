using System;

namespace _4._3.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int nums = int.Parse(Console.ReadLine());

                if (nums < 200) p1++;
                if (nums >= 200 && nums <= 399) p2++;
                if (nums >= 400 && nums <= 599) p3++;
                if (nums >= 600 && nums <= 799) p4++;
                if (nums >= 800) p5++;
            }

            Console.WriteLine($"{(p1 / n * 100):F2}%");
            Console.WriteLine($"{(p2 / n * 100):F2}%");
            Console.WriteLine($"{(p3 / n * 100):F2}%");
            Console.WriteLine($"{(p4 / n * 100):F2}%");
            Console.WriteLine($"{(p5 / n * 100):F2}%");
        }
    }
}
