using System;

namespace Strawberry
{
    class Strawberry
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 3;
            int dotCount = 1;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{1}\\{0}|{0}/{1}", new string('-', n - i * 2), new string('-', i * 2));
            }
  
            for (int i = 0; i < n /  2 + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('-', n - i * 2), new string('.', dotCount));
                dotCount += 4;
            }

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('-', i), new string('.', width - 2 - i * 2));
            }
        }
    }
}
