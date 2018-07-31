using System;

public class VariableInHexFormat
{
    public static void Main()
    {
        string hex = Console.ReadLine();

        Console.WriteLine("{0}", Convert.ToInt32(hex, 16));
    }
}