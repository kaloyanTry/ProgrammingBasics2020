using System;

namespace _6._2.NestedLoop
{
    class SumMagic2n
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int nMagic = int.Parse(Console.ReadLine());

            double counterN = 0;
            bool isMagicN = false;

            for (int i1 = n1; i1 <= n2; i1++)
            {
                for (int i2 = n1; i2 <= n2; i2++)
                {
                    counterN++;

                    if (i1 + i2 == nMagic)
                    {
                        Console.WriteLine($"Combination N:{counterN} ({i1} + {i2} = {nMagic})");
                        isMagicN = true;
                        break;
                    }
                }
                if (isMagicN) break;
            }

            if (!isMagicN)
            {
                Console.WriteLine($"{counterN} combinations - neither equals {nMagic}");
            }
        }
    }
}
