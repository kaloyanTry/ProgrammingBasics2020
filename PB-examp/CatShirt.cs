using System;

namespace CatShirt
{
    class CatShirt
    {
        static void Main(string[] args)
        {
            double sleeve = double.Parse(Console.ReadLine());
            double front = double.Parse(Console.ReadLine());
            string cloth = Console.ReadLine();
            string line = Console.ReadLine();
            double priceCloth = 0.0D;
            double priceTotal = 0.0D;

            double size = (sleeve + front) * 2;
            size = size + size * 0.1;
            size = size / 100;

            if (cloth == "Linen") priceCloth = 15.0;
            else if(cloth == "Cotton") priceCloth = 12.0;
            else if (cloth == "Denim") priceCloth = 20.0;
            else if (cloth == "Twill") priceCloth = 16.0;
            else if (cloth == "Flannel") priceCloth = 11.0;
            

            priceTotal = size * priceCloth + 10;
            if (line == "Yes") priceTotal = priceTotal + priceTotal * 0.2;
            else if (line == "No") priceTotal = priceTotal;

            Console.WriteLine($"The price of the shirt is: {priceTotal:F2}lv.");
        }
    }
}
