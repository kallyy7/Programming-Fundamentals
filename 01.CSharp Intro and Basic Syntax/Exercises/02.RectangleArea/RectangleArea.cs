using System;

public class RectangleArea
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double sum = a * b;

        Console.WriteLine($"{sum:f2}");
    }
}