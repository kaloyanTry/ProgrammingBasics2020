using System;

namespace PassengerPerFlight
{
    class PassengersAverage
    {
        static void Main(string[] args)
        {
            int numberAirlines = int.Parse(Console.ReadLine());
            
            int passengersPerFlight = 0;
            double passengersAverage = 0;
            string airLine = "";
            int counter = 0;
            int counterAll = 0;
            string airLineMax = "";
            double passengersMax = 0;

            for (int i = 1; i <= numberAirlines; i++)
            {
                string command = Console.ReadLine();
                while (command != "Finish" && counterAll <= numberAirlines)
                {
                    if (command == "Finish") break;
                    
                    else
                    {
                        int passengers = int.Parse(Console.ReadLine());
                        counterAll++;
                        passengersPerFlight += passengers;
                        counter++;
                        airLine = command;
                        passengersAverage = passengersPerFlight / counter;
                    }

                    if (passengersPerFlight > passengersMax)
                    {
                        passengersMax = passengersPerFlight;
                        airLineMax = airLine;
                    }
                    
                    if (counterAll == numberAirlines) break;
                    command = Console.ReadLine();
                }
                Console.WriteLine($"{airLine}: {passengersPerFlight}passengers.");
            }
            
            Console.WriteLine($"{airLineMax} has most passengers per flight: {passengersMax}");
        }
    }
}
