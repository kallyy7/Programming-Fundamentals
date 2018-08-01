using System;
using System.Linq;

public class ShortWordsSorted
{
    public static void Main()
    {
        var separators = new[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };
        string word = Console.ReadLine().ToLower();
        string[] words = word.Split(separators);

        var result = words
        .Where(w => w != "")
        .Where(w => w.Length < 5)
        .OrderBy(w => w)
        .Distinct();

        Console.WriteLine(string.Join(", ", result));
    }
}