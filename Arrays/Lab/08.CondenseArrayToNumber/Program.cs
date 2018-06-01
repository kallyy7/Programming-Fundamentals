using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine($"{numbers[0]} is already condensed to number");
                return;
            }

            int[] condensed = new int[numbers.Length];
            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                condensed[i] = numbers[i] + numbers[i + 1];
                sum += condensed[i];
            }

            Console.WriteLine(sum);
        }
    }
}
