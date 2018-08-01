using System;

public class TemperatureConversion
{
    public static void Main()
    {
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsium = FahrenheitToCelsium(fahrenheit);

        Console.WriteLine($"{celsium:F2}");
    }
    private static double FahrenheitToCelsium(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}