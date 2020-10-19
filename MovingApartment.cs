using System;

namespace _5._2.MovingApartment
{
    class Program
    {
        static void Main(string[] args)
        {
            int widt = int.Parse(Console.ReadLine());
            int leght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int space = widt * leght * hight;

            string input = Console.ReadLine();
            int numsSpace = 0;
            while (input != "Done")
            {
                int nums = int.Parse(input);
                numsSpace += nums;
                if (numsSpace > space)
                {  
                    break;
                }
                input = Console.ReadLine();
            }
            if (numsSpace > space)
            {
                Console.WriteLine($"No more free space! You need {(numsSpace - space)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{space - numsSpace} Cubic meters left.");
            }
        }
    }
}
