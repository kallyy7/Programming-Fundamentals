using System;

public class RandomizeWords
{
    public static void Main()
    {
        string[] words = Console.ReadLine().Split(' ');

        Random randomWords = new Random();

        for (int firstPos = 0; firstPos < words.Length; firstPos++)
        {
            int secondPos = randomWords
                .Next(words.Length);

            string temp = words[firstPos];
            words[firstPos] = words[secondPos];
            words[secondPos] = temp;
        }

        Console.WriteLine(string.Join("\r\n", words));
    }
}