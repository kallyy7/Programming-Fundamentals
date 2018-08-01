using System;

public class IndexOfLetters
{
    public static void Main()
    {
        string word = Console.ReadLine();
        char[] arr = new char[26];

        for (int i = 0; i < 26; i++)
        {
            arr[i] = (char)('a' + i);
        }

        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine(word[i] + " -> " + Array.IndexOf(arr, word[i]));
        }
    }
}