using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                numbers[i] = input;
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
