using System;
using System.Linq;

public class ArrayStatistics
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine($"Min = {Min(numbers)}");
        Console.WriteLine($"Max = {Max(numbers)}");
        Console.WriteLine($"Sum = {Sum(numbers)}");
        Console.WriteLine($"Average = {Average(numbers)}");
    }
    private static int Min(int[] numbers)
    {
        return numbers.Min();
    }
    private static int Max(int[] numbers)
    {
        return numbers.Max();
    }
    private static int Sum(int[] numbers)
    {
        int result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }
        return result;
    }
    private static double Average(int[] numbers)
    {
        return numbers.Average();
    }
}