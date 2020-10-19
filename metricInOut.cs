using System;

namespace _2._3.ConditionsLab2
{
    class metricInOut
    {
        static void Main(string[] args)
        {

            double size = double.Parse(Console.ReadLine());
            string inMetric = Console.ReadLine();
            string outMetric = Console.ReadLine();
            double meter = 0.0;
            double result = 0.0;

            if (inMetric == "m")
            {
                meter = size;
            }
            else if (inMetric == "mm")
            {
                meter = size / 1000.0;
            }
            else if (inMetric == "cm")
            {
                meter = size / 100.0;
            }

            if (outMetric == "m")
            {
                result = meter;
                Console.WriteLine($"{result:F3}");
            }
            else if (outMetric == "cm")
            {
                result = meter / 0.01;
                Console.WriteLine($"{result:F3}");
            }
            else if (outMetric == "mm")
            {
                result = meter / 0.001;
                Console.WriteLine($"{result:F3}");
            }
        }
    }
}
