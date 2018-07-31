using System;

public class CountSubstringOccurences
{
    public static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string searchWord = Console.ReadLine().ToLower();

        int counter = 0;
        int searchResult = input.IndexOf(searchWord);

        while (!searchResult.Equals(-1))
        {
            counter++;
            searchResult = input.IndexOf(searchWord, searchResult + 1);
        }

        Console.WriteLine(counter);
    }
}