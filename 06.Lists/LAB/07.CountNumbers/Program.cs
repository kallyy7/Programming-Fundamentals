using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> nums = new List<int>();
            numbers.Sort();
            int count = 0;
            int curr = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                curr = numbers[i];

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
