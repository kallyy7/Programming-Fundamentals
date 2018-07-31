using System;

public class MilesToKm
{
    public static void Main()
    {
        double miles = double.Parse(Console.ReadLine());
        double milesToKm = miles * 1.60934;

        Console.WriteLine($"{milesToKm:f2}");
    }
}