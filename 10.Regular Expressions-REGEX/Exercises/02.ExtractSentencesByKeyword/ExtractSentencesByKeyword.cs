using System;
using System.Text.RegularExpressions;

public class ExtractSentencesByKeyword
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string text = Console.ReadLine();
        string pattern = $@"\b[^.?!]*\b{input}\b[^.?!]*";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}