using System;
using System.Security.Cryptography;

namespace _6._3.NestedLoops
{
    class SpecNums
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i1 = 1; i1 <= 9; i1++)
            {
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    for (int i3 = 1; i3 <= 9; i3++)
                    {
                        for (int i4 = 1; i4 <= 9; i4++)
                        {
                            if (num % i1 == 0 && num % i2 == 0 && num % i3 == 0 && num % i4 == 0)
                            {
                                Console.Write($"{i1}{i2}{i3}{i4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
