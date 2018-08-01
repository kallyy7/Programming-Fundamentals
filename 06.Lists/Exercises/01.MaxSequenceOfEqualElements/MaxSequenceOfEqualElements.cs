using System;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        int[] inputArr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int counter = 0;
        int count = 0;
        int max = 0;

        for (int i = 0; i < inputArr.Length - 1; i++)
        {
            if (inputArr[i] == inputArr[i + 1])
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
            Console.Write(inputArr[i] + " ");
        }

        Console.WriteLine();
    }
}