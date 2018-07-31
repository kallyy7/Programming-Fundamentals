using System;

public class MakeAWord
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        string word = null;

        for (int i = 1; i <= number; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            word += letter;
        }

        Console.Write($"The word is: {word}");
    }
}