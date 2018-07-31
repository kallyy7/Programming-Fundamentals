using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            numbers.Sort();
            numbers.Reverse();

            foreach (var item in numbers)
            {
                double sqrt = Math.Sqrt(item);
                if (sqrt == (int)sqrt)
                {
                    Console.Write(item + " ");
                }
            }

        }
    }
}
