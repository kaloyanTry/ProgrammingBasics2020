using System;

namespace _2._3.ConditionsLab22
{
    class ScholarshipExSoc
    {
        static void Main(string[] args)
        {
            double incomeBGN = double.Parse(Console.ReadLine());
            double marksAverage = double.Parse(Console.ReadLine());
            double salaryMin = double.Parse(Console.ReadLine());

            double scholarshipEx = 0;
            double scholarshipSoc = 0;

            if (marksAverage >= 5.5)
            {
                scholarshipEx = marksAverage * 25;
            }
            
            if (marksAverage >= 4.50 && incomeBGN < salaryMin)
            {
                scholarshipSoc = salaryMin * 0.35;
            }

            if (scholarshipSoc > 0 && scholarshipEx == 0)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(scholarshipSoc)} BGN");
            }
            else if (scholarshipEx > 0 && scholarshipSoc == 0)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholarshipEx)} BGN");
            }
            else if (scholarshipSoc > 0 && scholarshipEx > 0)
            {
                if (scholarshipSoc == scholarshipEx)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholarshipEx)} BGN");
                }
                else if (scholarshipSoc > scholarshipEx)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(scholarshipSoc)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholarshipEx)} BGN");
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
