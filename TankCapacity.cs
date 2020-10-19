using System;

namespace _1._2.Convertors
{
    class TankCapacity
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int widt = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double tank = (lenght * widt * height) * 0.001;
            tank = tank - tank * percent / 100;

            Console.WriteLine(tank);
        }
    }
}
