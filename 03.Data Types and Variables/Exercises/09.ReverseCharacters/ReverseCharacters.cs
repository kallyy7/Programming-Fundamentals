using System;

public class ReverseCharacters
{
    public static void Main()
    {
        string firstLetter = Console.ReadLine();
        string secondLetter = Console.ReadLine();
        string thirdLetter = Console.ReadLine();

        string order = firstLetter + secondLetter + thirdLetter;
        char[] charArray = order.ToCharArray();
        Array.Reverse(charArray);

        Console.WriteLine(charArray);
    }
}