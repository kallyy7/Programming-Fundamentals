using System;
using System.Linq;

namespace _07.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            MostFrequentNumber(numbers);
        }
        static void MostFrequentNumber(int[] numbers)
        {
            int counter = 0;
            int longestFreq = 0;
            int frequentNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                counter = 0;

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
