using System;
using System.Linq;

public class MostFrequentNumber
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            getMostFrequentNumber(numbers);
        }
        private static void getMostFrequentNumber(int[] numbers)
        {
            int longestFreq = 0;
            int frequentNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        counter++;
                    }
                }

                if (counter > longestFreq)
                {
                    longestFreq = counter;
                    frequentNumber = numbers[i];
                }
            }

            Console.WriteLine(frequentNumber);
        }
    }
}
