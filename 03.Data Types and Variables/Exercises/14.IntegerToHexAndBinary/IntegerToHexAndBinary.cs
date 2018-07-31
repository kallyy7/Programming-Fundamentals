using System;

public class IntegerToHexAndBinary
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        string hex = number.ToString("X");
        string binary = Convert.ToString(number, 2).ToUpper();

        Console.WriteLine($"{hex}\n{binary}");
    }
}