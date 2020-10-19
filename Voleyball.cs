using System;

namespace _3._3Voleyball
{
    class Voleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double fests = double.Parse(Console.ReadLine());
            double weekendsHome = double.Parse(Console.ReadLine());

            int yearWeekends = 48;
            double inSofia = yearWeekends - weekendsHome;
            double yesVoley = inSofia * 3 / 4;
            double yesFest = fests * 2 / 3;
            double totalVoley = yesVoley + yesFest + weekendsHome;

            if (year == "leap") totalVoley = totalVoley + totalVoley * 15 / 100;
            if (year == "normal") totalVoley = totalVoley;

            Console.WriteLine(Math.Floor(totalVoley));

        }
    }
}
