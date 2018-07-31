using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._02.OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .ToList();

            double numListAvetage = numbers.Average();

            numbers = numbers.Select(x => x > numListAvetage ? ++x : --x)
                .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
 }

