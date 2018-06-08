using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            List<double> nums = new List<double>();
            numbers.Sort();
            double count = 0;
            double curr = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                curr = numbers[i];
                count = 0;
                if (!nums.Contains(numbers[i]))
                {
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (curr == numbers[j])
                        {
                            count++;
                        }
                        nums.Add(numbers[i]);
                    }

                    Console.WriteLine($"{curr} -> {count}");
                }

            }
        }
    }
}
