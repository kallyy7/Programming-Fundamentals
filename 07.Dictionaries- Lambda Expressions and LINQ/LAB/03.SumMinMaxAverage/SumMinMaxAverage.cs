using System;
using System.Linq;

public class SumMinMaxAverage
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var numbers = new double[n];

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