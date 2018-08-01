using System;

public class MathPower
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        double result = PowerNumber(number, power);

        Console.WriteLine(result);
    }
    private static double PowerNumber(double number, int power)
    {
        return Math.Pow(number, power);
    }
}