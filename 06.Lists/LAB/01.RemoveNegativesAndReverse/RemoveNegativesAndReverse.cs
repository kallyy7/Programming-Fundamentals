using System;
using System.Linq;
using System.Collections.Generic;

public class RemoveNegativesAndReverse
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < 0)
            {
                numbers.RemoveAt(i);
                i--;
            }
        }

        if (numbers.Count.Equals(0))
        {
            Console.WriteLine("empty");
        }
        else
        {
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}