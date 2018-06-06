using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> searchNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int count = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < searchNumbers.Count; j++)
                {
                    if (numbers[i] == searchNumbers[j])
                    {
                        count++;
                    }
                }
            }

            if(count == searchNumbers.Count)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
