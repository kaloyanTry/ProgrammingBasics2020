using System;

namespace _5._3.While
{
    class WalkingSteps
    {
        static void Main(string[] args)
        {
            string command = (Console.ReadLine());
            int stepsTotal = 0;

            while (command != "Going home")
            {
                int steps = int.Parse(command);   
                stepsTotal += steps;

                if (stepsTotal >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsTotal - 10000} steps over the goal!");
                    break;
                }
                command = (Console.ReadLine());
            }

            if (command == "Going home")
            {
                int stepsMore = int.Parse(Console.ReadLine());
                if (stepsTotal + stepsMore < 10000)
                {
                    Console.WriteLine($"{10000 - (stepsTotal + stepsMore)} more steps to reach goal.");
                }
                else
                {
                    stepsTotal += stepsMore;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsTotal - 10000} steps over the goal!");
                }
            }
        }
    }
}
