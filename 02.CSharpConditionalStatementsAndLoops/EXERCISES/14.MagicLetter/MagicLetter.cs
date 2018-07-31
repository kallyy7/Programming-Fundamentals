using System;

public class MagicLetter
{
    public static void Main()
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        char noPrintLetter = char.Parse(Console.ReadLine());

        for (char a = firstLetter; a <= secondLetter; a++)
        {
            for (char b = firstLetter; b <= secondLetter; b++)
            {
                for (char c = firstLetter; c <= secondLetter; c++)
                {
                    if (a != noPrintLetter && b != noPrintLetter && c != noPrintLetter)
                    {
                        Console.Write($"{a}{b}{c} ");
                    }
                }
            }
        }
    }
}