using System;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        int[] inputNumbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int counter = 0;
        int count = 0;
        int max = 0;

        for (int i = 0; i < inputNumbers.Length - 1; i++)
        {
            if (inputNumbers[i] == inputNumbers[i + 1])
            {
                count++;
                if (count > max)
                {
                    counter = i - count;
                    max = count;
                }
            }
            else
            {
                count = 0;
            }
        }

        for (int i = counter + 1; i <= counter + max + 1; i++)
        {
            Console.Write(inputNumbers[i] + " ");
        }
        Console.WriteLine();

    }
}