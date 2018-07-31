using System;

namespace _02.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sum = a * b;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
