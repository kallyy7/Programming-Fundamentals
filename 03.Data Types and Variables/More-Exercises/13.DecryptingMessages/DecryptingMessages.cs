using System;

public class DecryptingMessages
{
    public static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int numberLines = int.Parse(Console.ReadLine());

        string print = null;

        for (int i = 1; i <= numberLines; i++)
        {
            char curentChar = char.Parse(Console.ReadLine());
            print += (char)(curentChar + key);
        }

        Console.WriteLine(print);
    }
}