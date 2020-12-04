using System;

namespace _5._3.Cake
{
    class CakeLeft
    {
        static void Main(string[] args)
        {
            double widt = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());

            double piecesCake = widt * lenght;
            double totalCake = 0.0;
            string command = Console.ReadLine();

            while (totalCake <= piecesCake && command != "STOP")
            {
                int input = int.Parse(command);
                totalCake += input;
                if (totalCake >  piecesCake)
                {
                    Console.WriteLine($"No more cake left! You need {totalCake - piecesCake} pieces more.");
                    break;
                }
                command = Console.ReadLine();
            }
            
            if (command == "STOP")
            {
                Console.WriteLine($"{piecesCake - totalCake} pieces are left.");
            }
        }
    }
}
