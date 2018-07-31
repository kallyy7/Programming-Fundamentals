using System;
using System.Linq;
using System.Text.RegularExpressions;

public class AnonymousVox
{
    public static void Main()
    {
        string encodedText = Console.ReadLine();
        string[] placeholders = Console.ReadLine()
            .Split("{ }".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string pattern = @"([A-Za-z]+)(.+)(\1)";
        MatchCollection matches = Regex.Matches(encodedText, pattern);
        string replaced = null;
        int count = 0;

        foreach (Match match in matches)
        {
            string current = match.Groups[2].Value;
            string currentPlaceholder = placeholders[count];

            string decoded = match.Groups[1] + placeholders[count] + match.Groups[3];
            encodedText = encodedText.Replace(match.Groups[0].Value, decoded);

            replaced = encodedText.Replace(current, currentPlaceholder);
            count++;
        }

        Console.WriteLine(replaced);
    }
}