using System;

namespace _6._2.Building
{
    class Building
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int fl = floors; fl >= 1; fl--)
            {
                for (int r = 0; r <= rooms - 1; r++)
                {
                    if (fl == floors)
                    {
                        if (r == rooms - 1) Console.Write($"L{fl}{r}");
                        else Console.Write($"L{fl}{r} ");   
                    }
                    else
                    {
                        if (fl % 2 == 0)
                        {
                            if (r == rooms - 1) Console.Write($"O{fl}{r}");
                            else Console.Write($"O{fl}{r} ");
                        }
                        else
                        {
                            if (r == rooms - 1)  Console.Write($"A{fl}{r}");
                            else Console.Write($"A{fl}{r} ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
