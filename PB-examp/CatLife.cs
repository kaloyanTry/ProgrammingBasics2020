using System;

namespace CatLife
{
    class CatLife
    {
        static void Main(string[] args)
        {
            string cat = Console.ReadLine();
            char gender = char.Parse(Console.ReadLine());
            bool isCat = (cat == "British Shorthair" || cat == "Siamese" || cat == "Persian" || cat == "Ragdoll"|| cat == "American Shorthair" || cat == "Siberian");
            double catYears = 0.0;
            double humanYears = 0.0;

            if (gender == 'm')
            {
                switch (cat)
                {
                    case "British Shorthair":
                        catYears = 13;
                        break;
                    case "Siamese":
                        catYears = 15;
                        break;
                    case "Persian":
                        catYears = 14;
                        break;
                    case "Ragdoll":
                        catYears = 16;
                        break;
                    case "American Shorthair":
                        catYears = 12;
                        break;
                    case "Siberian":
                        catYears = 11;
                        break;
                    default:
                        Console.WriteLine($"{cat} is invalid cat!");
                        break;
                }

            }
            if (gender == 'f')
            {
                switch (cat)
                {
                    case "British Shorthair":
                        catYears = 14;
                        break;
                    case "Siamese":
                        catYears = 16;
                        break;
                    case "Persian":
                        catYears = 15;
                        break;
                    case "Ragdoll":
                        catYears = 17;
                        break;
                    case "American Shorthair":
                        catYears = 13;
                        break;
                    case "Siberian":
                        catYears = 12;
                        break;
                    default:
                        Console.WriteLine($"{cat} is invalid cat!");
                        break;
                }

            }
            humanYears = catYears * 12;
            double catMonths = Math.Floor(humanYears / 6);
            if (isCat) Console.WriteLine($"{catMonths} cat months");
        }
    }
}
