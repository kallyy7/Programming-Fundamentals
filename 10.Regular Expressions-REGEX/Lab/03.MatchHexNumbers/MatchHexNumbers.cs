using System;
using System.Linq;
using System.Text.RegularExpressions;

public class MatchHexNumbers
{
    public static void Main()
    {
        string pattern = @"\b(?:0x)?[0-9A-F]+\b";

        string input = Console.ReadLine();
        var numbers = Regex.Matches(input, pattern)
            .Select(n => n.Value)
            .ToArray();

        Console.WriteLine(string.Join(" ", numbers));
    }
}