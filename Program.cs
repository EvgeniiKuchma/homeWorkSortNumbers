using System;

namespace homeWorkSortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numbresArraySize = 10;
            int minValue = 1;
            int maxValue = 10;
            int tempNumber = 1;

            int[] numberesArray = new int[numbresArraySize];

            for (int i = 0; i < numbresArraySize; i++)
            {
                numberesArray[i] = random.Next(minValue, maxValue);
            }

            foreach (int numberes in numberesArray)
            {
                Console.Write($"{numberes} ");
            }

            Console.WriteLine("\n\n");

            for (int i = 0; i < numberesArray.Length; i++)
            {
                for (int j = 0; j < numberesArray.Length - 1; j++)
                {
                    if (numberesArray[j] > numberesArray[j + 1])
                    {
                        tempNumber = numberesArray[j + 1];
                        numberesArray[j + 1] = numberesArray[j];
                        numberesArray[j] = tempNumber;
                    }
                }
            }

            for (int i = 0; i < numberesArray.Length; i++)
            {
                Console.Write(numberesArray[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
