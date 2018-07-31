using System;
using System.Text.RegularExpressions;

public class ReplaceTag
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"<a.*?href=(.*?)>(.*?)<\/a>";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);

        foreach (Match item in matches)
        {
            regex.Replace(input, item.ToString());
            string replace = @"[URL href=" + item.Groups[1] + "]" + item.Groups[2] + "[/URL]";

            Console.WriteLine(Regex.Replace(input, pattern, replace));
        }
    }
}