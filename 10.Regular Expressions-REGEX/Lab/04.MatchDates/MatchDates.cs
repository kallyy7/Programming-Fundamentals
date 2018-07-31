using System;
using System.Text.RegularExpressions;

public class MatchDates
{
    public static void Main()
    {
        var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
        string input = Console.ReadLine();
        var dates = Regex.Matches(input, regex);

        foreach (Match date in dates)
        {
            string day = date.Groups["day"].Value;
            string month = date.Groups["month"].Value;
            string year = date.Groups["year"].Value;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}