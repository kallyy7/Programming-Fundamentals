using System;

public class UnicodeCharacters
{
    public static void Main()
    {
        char[] input = Console.ReadLine()
            .ToCharArray();

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("\\u{0:x4}", (int)input[i]);
        }

        Console.WriteLine();
    }
}