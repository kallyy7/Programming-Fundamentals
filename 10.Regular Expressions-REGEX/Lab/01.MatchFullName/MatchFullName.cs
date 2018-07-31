using System;
using System.Text.RegularExpressions;

public class MatchFullName
{
    public static void Main()
    {
        string pattrern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        string names = Console.ReadLine();

        MatchCollection machesNames = Regex.Matches(names, pattrern);

        foreach (Match name in machesNames)
        {
            Console.Write(name.Value + " ");
        }

        Console.WriteLine();
    }
}