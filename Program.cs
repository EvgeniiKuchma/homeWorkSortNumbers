using System;

namespace homeWorkSortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberesArraySize = 10;
            int minValue = 1;
            int maxValue = 10;
            int tempNumber = 0;

            int[] numberesArray = new int[numberesArraySize];

            for (int i = 0; i < numberesArraySize; i++)
            {
                numberesArray[i] = random.Next(minValue, maxValue);
            }

            for (int i = 0; i < numberesArraySize - 1; i++)
            {
                if (numberesArray[i] > numberesArray[i + 1])
                {
                    tempNumber = numberesArray[i];
                    numberesArray[i + 1] = numberesArray[i];
                    numberesArray[i] = tempNumber;
                }

                Console.Write(numberesArray[i] + ", ");
            }

            Console.WriteLine();
        }
    }
}
