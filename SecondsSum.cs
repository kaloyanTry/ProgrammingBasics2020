using System;

namespace _2._3.ConditionsLab
{
    class SecondsSum
    {
        static void Main(string[] args)
        {
            int timeFirst = int.Parse(Console.ReadLine());
            int timeSecond = int.Parse(Console.ReadLine());
            int timeThird = int.Parse(Console.ReadLine());

            int timeTotal = timeFirst + timeSecond + timeThird;
            double minutes = timeTotal / 60;
            double seconds = timeTotal % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
