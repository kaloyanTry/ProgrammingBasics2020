using System;

namespace GameOfNames
{
    class GameNames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalScore = 0;
            int maxScore = 0;
            string maxName = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int score = int.Parse(Console.ReadLine());

                totalScore = score;

                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] % 2 == 0)
                    {
                        totalScore += name[j];                       
                    }
                    else
                    {
                        totalScore -= name[j];                       
                    }
                }

                if (totalScore > maxScore)
                {
                    maxScore = totalScore;
                    maxName = name;
                }
            }

            Console.WriteLine($"The winner is {maxName} - {maxScore} points");
        }
    }
}
