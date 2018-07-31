using System;
using System.Linq;

public class LettersChangeNumbers
{
    public static void Main()
    {
        string[] input = Console.ReadLine()
            .Split("\t ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        decimal totalSum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char leftLetter = char.Parse(input[i].Substring(0, 1));
            char rightLetter = char.Parse(input[i].Substring(input[i].Length - 1));
            decimal number = decimal.Parse(input[i].Substring(1, input[i].Length - 2));

            if (char.IsUpper(leftLetter))
            {
                number = number / (leftLetter - 64);
            }
            else if (char.IsLower(leftLetter))
            {
                number = number * (leftLetter - 96);
            }

            if (char.IsUpper(rightLetter))
            {
                number = number - (rightLetter - 64);
            }
            else if (char.IsLower(rightLetter))
            {
                number = number + (rightLetter - 96);
            }

            totalSum += number;
        }

        Console.WriteLine($"{totalSum:f2} ");
    }
}