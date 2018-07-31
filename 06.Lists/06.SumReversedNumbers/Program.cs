using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
              .Split()
              .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = ReverseString(numbers[i]);
            }

            Console.WriteLine(numbers.Select(int.Parse).ToList().Sum());

        }

        static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }


    }
    
}
