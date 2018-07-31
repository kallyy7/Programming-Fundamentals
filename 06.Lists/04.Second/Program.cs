using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Second
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            List<int> longestNums = new List<int>();

            for (int i = 1; i < numbers.Count; i++)
            {
                List<int> currentMax = longestNums.ToList();
                LIS(numbers, longestNums);
                if (longestNums.Count < currentMax.Count)
                {
                    
                }
                
            }

        }
        static void LIS(List<int> numbers, List<int> longestNums)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int curr = numbers[i];
                int next = numbers[i + 1];

                if (curr < next)
                {
                    longestNums.Add(curr);
                }

            }
        }
    }
}
