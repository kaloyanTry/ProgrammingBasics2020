using System;
using System.Linq;

namespace ArrayModifier
{
    class ArrayModifier
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split().Select(long.Parse).ToArray();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputData = input.Split();
                string command = inputData[0];

                switch (command)
                {
                    case "swap":
                        int indexFirst = int.Parse(inputData[1]);
                        int indexSecond = int.Parse(inputData[2]);
                        long indexTemp = array[indexFirst];

                        array[indexFirst] = array[indexSecond];
                        array[indexSecond] = indexTemp;
                        break;

                    case "multiply":
                        int indexFirstMulti = int.Parse(inputData[1]);
                        int indexSecondMulti = int.Parse(inputData[2]);

                        array[indexFirstMulti] *= array[indexSecondMulti];

                        break;

                    case "decrease":
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = array[i] - 1;
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
