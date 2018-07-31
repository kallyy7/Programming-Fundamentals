using System;
using System.Linq;

public class CharacterMultiplier
{
    public static void Main()
    {
        string[] input = Console.ReadLine()
            .Split()
            .ToArray();
        int sum = 0;
        char[] first = input[0].ToCharArray();
        char[] second = input[1].ToCharArray();

        for (int i = 0; i < Math.Max(first.Length, second.Length); i++)
        {
            if (first.Length < i + 1)
            {
                sum += second[i];
            }
            else if (second.Length < i + 1)
            {
                sum += first[i];
            }
            else
            {
                sum += first[i] * second[i];
            }
        }

        Console.WriteLine(sum);
    }
}