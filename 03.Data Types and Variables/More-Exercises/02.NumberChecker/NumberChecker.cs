using System;

public class NumberChecker
{
    public static void Main()
    {
        string number = Console.ReadLine();

        if (number.Contains("."))
        {
            Console.WriteLine("floating-point");
        }
        else
        {
            Console.WriteLine("integer");
        }
    }
}