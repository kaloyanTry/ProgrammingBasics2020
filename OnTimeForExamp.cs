using System;

namespace _3._3.Nestee
{
    class OnTimeForExamp
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            var examTime = (examHour * 60) + examMinute;
            var arrivalTime = (arrivalHour * 60) + arrivalMinute;
            var diffTime = arrivalTime - examTime;
            var secondDiff = examTime - arrivalTime;

            if (diffTime <= 59 && diffTime > 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{diffTime} minutes after the start");
            }
            else if (diffTime >= 60)
            {
                var hour = diffTime / 60;
                var minutes = diffTime % 60;
                Console.WriteLine("Late");
                Console.WriteLine($"{hour}:{minutes:00} hours after the start");
            }
            else if (secondDiff == 0)
            {
                Console.WriteLine("On time");
            }
            else if (secondDiff <= 30 && secondDiff > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{secondDiff} minutes before the start");
            }
            else if (secondDiff > 30 && secondDiff < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{secondDiff} minutes before the start");
            }
            else if (secondDiff >= 60)
            {
                var hour = secondDiff / 60;
                var minutes = secondDiff % 60;
                Console.WriteLine("Early");
                Console.WriteLine($"{hour}:{minutes:00} hours before the start");
            }
        }
    }
}
