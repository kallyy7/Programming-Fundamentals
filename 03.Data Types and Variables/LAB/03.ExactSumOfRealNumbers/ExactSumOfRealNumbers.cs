using System;

public class ExactSumOfRealNumbers
{
    public static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        decimal sum = 0;

        for (int i = 0; i < n; i++)
        {
            decimal numbers = decimal.Parse(Console.ReadLine());
            sum += numbers;
        }

        Console.WriteLine(sum);
    }
}