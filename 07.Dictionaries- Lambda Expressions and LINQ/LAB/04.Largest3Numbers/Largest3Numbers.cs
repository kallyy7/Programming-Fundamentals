using System;
using System.Linq;

public class Largest3Numbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        var result = numbers
            .OrderByDescending(x => x)
            .Take(3);

        Console.WriteLine(string.Join(" ", result));
    }
}