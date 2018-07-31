using System;
using System.Linq;

namespace _01.ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(). Select(int.Parse).ToArray();

            Console.WriteLine($"Min = {Min(numbers)}");
            Console.WriteLine($"Max = {Max(numbers)}");
            Console.WriteLine($"Sum = {Sum(numbers)}");
            Console.WriteLine($"Average = {Average(numbers)}");
        }
        static int Min (int[] numbers)
        {
            return numbers.Min();
        }
        static int Max (int[] numbers)
        {
            return numbers.Max();
        }
        static int Sum (int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }
        static double Average (int[] numbers)
        {
            return (double)numbers.Average();
        }
    }
}
