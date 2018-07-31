using System;
using System.Linq;


namespace _10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            PairsByDifference(numbers, difference);
        }
        static void PairsByDifference(int[] numbers, int difference)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = 0; j < numbers.Length; j++)
                {

                    if ((numbers[i] - numbers[j]) == difference)
                    {
                        //Console.WriteLine($"{numbers[i]}, {numbers[j]}");
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
