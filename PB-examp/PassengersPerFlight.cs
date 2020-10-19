using System;

namespace Airlines
{
    class PassengersPerFlight
    {
        static void Main(string[] args)
        {
            int numberCompanies = int.Parse(Console.ReadLine());
            double passengersPerFlight = 0;
            int counterPerFlight = 0;
            double maxFlight = 0;
            string maxCompany = "";

            for (int i = 1; i <= numberCompanies; i++)
            {
                string companyName = Console.ReadLine();
                string command = "";

                while (command != "Stop")
                {
                    command = Console.ReadLine();
                    if (command == "Finish") break;
                    
                    int passengers = int.Parse(command);
                    passengersPerFlight += passengers;
                    counterPerFlight++;
                }

                double averagePassengers = Math.Floor(passengersPerFlight / counterPerFlight);

                Console.WriteLine($"{companyName}: {averagePassengers} passengers.");

                if (averagePassengers > maxFlight)
                {
                    maxFlight = averagePassengers;
                    maxCompany = companyName;
                }
                passengersPerFlight = 0;
                counterPerFlight = 0;
            }

            Console.WriteLine($"{maxCompany}: has most passengers per flight: {maxFlight}");
        }
    }
}
