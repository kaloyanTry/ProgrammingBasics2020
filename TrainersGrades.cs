using System;

namespace _6._3.TrainTrainers
{
    class TrainersGrades
    {
        static void Main(string[] args)
        {
            int numberJudges = int.Parse(Console.ReadLine());
            string namePresentation = Console.ReadLine();
            double avrAll = 0;
            double gradesAll = 0;
            int avrCounter = 0;

            while (namePresentation != "Finish")
            {
                if (namePresentation == "Finish") break;

                for (int i = 1; i <= numberJudges; i++)
                {
                    double grades = double.Parse(Console.ReadLine());
                    gradesAll += grades;
                }
                double avrGrades = gradesAll / numberJudges;
                Console.WriteLine($"{namePresentation} - {avrGrades:F2}.");
                avrCounter++;
                avrAll += avrGrades;
                avrGrades = 0;
                gradesAll = 0;
                namePresentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(avrAll / avrCounter):F2}.");
        }
    }
}
