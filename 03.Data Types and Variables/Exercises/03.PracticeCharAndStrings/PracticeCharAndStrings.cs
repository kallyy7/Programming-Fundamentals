using System;

public class PracticeCharAndStrings
{
    public static void Main()
    {
        string firstString = Console.ReadLine();
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());
        char thirdChar = char.Parse(Console.ReadLine());
        string secondString = Console.ReadLine();

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", firstString, firstChar, secondChar, thirdChar, secondString);
    }
}