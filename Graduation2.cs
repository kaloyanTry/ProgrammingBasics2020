using System;

namespace _5._2.WhileLab
{
    class Graduation2
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int countMarks = 0;
            double sumMarks = 0;
            int countLowMarks = 0;

            while (true)
            {
                double marks = double.Parse(Console.ReadLine());
                
                if (marks < 4)
                {
                    countLowMarks++;
                    if (countLowMarks > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {countMarks} grade");
                        break;
                    }
                }
                sumMarks += marks;
                countMarks++;
                if (countMarks == 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {(sumMarks / countMarks):F2}");
                    break;
                }
            }
        }
    }
}
