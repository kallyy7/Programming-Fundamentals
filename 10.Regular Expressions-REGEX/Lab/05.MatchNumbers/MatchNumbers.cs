using System;
using System.Text.RegularExpressions;

public class MatchNumbers
{
    public static void Main()
    {
        string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

        string input = Console.ReadLine();
        var numbers = Regex.Matches(input, pattern);

        foreach (Match n in numbers)
        {
            Console.Write(n.Value + " ");
        }

        Console.WriteLine();
    }
}