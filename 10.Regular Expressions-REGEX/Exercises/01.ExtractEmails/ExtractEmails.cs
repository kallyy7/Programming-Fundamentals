using System;
using System.Text.RegularExpressions;

public class ExtractEmails
{
    public static void Main()
    {
        string input = Console.ReadLine();

        string pattern = @"\b(?<!\S)[a-z][a-z0-9\.\-_]+[a-z0-9]*@[a-z][a-z\-]+\.[a-z][a-z\.]+[a-z]?\b";
        var matches = Regex.Matches(input, pattern);

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}