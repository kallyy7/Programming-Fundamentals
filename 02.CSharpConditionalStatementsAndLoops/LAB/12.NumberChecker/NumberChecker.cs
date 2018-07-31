using System;

public class NumberChecker
{
    public static void Main()
    {
        try
        {
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("It is a number.");
        }
        catch
        {
            Console.WriteLine("Invalid input!");
        }
    }
}