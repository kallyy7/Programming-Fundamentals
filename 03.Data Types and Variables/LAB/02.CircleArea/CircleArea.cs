using System;

public class CircleArea
{
    public static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;

        Console.WriteLine($"{area:f12}");
    }
}