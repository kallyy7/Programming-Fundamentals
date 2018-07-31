using System;

public class HouseBuilder
{
    public static void Main()
    {
        long firstNumber = long.Parse(Console.ReadLine());
        long SecoundNnumber = long.Parse(Console.ReadLine());

        long a = Math.Min(firstNumber, SecoundNnumber);
        long b = Math.Max(firstNumber, SecoundNnumber);
        long sum = a * 4 + b * 10;

        Console.WriteLine(sum);
    }
}