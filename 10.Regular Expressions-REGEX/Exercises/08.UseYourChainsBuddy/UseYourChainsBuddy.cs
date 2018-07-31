using System;
using System.Text;
using System.Text.RegularExpressions;

public class UseYourChainsBuddy
{
    public static void Main()
    {
        string htmlText = Console.ReadLine();
        string pattern = @"<p>(.+?)<\/p>";
        string currentMach = null;

        foreach (Match match in Regex.Matches(htmlText, pattern))
        {
            currentMach += match.Groups[1].Value;
        }

        currentMach = Regex.Replace(currentMach, @"[^a-z\d]", " ");
        currentMach = Regex.Replace(currentMach, @"\s+|\n+", " ");
        StringBuilder result = new StringBuilder(currentMach.Length);

        foreach (var ch in currentMach)
        {
            if (ch >= 'a' && ch <= 'm')
            {
                result.Append((char)(ch + 13));
            }
            else if (ch >= 'n' && ch <= 'z')
            {
                result.Append((char)(ch - 13));
            }
            else
            {
                result.Append(ch);
            }
        }

        Console.WriteLine(result);
    }
}