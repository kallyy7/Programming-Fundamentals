using System;

public class ExchangeVariableValues
{
    public static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        Console.Write($"Before:\na = {first}\nb = {second}\n");

        int temp = first;
        first = second;
        second = temp;

        Console.WriteLine($"After:\na = {first}\nb = {second}\n");
    }
}