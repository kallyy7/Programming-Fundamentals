using System;
using System.Collections.Generic;
using System.Linq;

public class SquareNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        numbers.Sort();
        numbers.Reverse();

        foreach (var item in numbers)
        {
            double sqrt = Math.Sqrt(item);

            if (sqrt == (int)sqrt)
            {
                Console.Write(item + " ");
            }
        }
    }
}