using System;
using System.ComponentModel.Design.Serialization;

namespace SantasGifts
{
    class Gifts
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            for (int i1 = M; i1 >= N; i1--)
            {
                if (i1 % 2 == 0 && i1 % 3 == 0)
                {
                    if (i1 == S) break;

                    else
                    {
                        Console.Write($"{i1} ");
                    }
                }

            }

        }
    }
}
