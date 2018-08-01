using System;
using System.Linq;
using System.Collections.Generic;

public class MaxSequenceOfIncreasingElements
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        MaxIncSequence(numbers);
    }

    private static void MaxIncSequence(int[] numbers)
    {
        int count = 0;
        int max = 0;
        int max2 = 0;
        List<int> result = new List<int>();

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] - numbers[i - 1] >= 1)
            {
                count++;
                int startCount = i - count;

                if (count > max)
                {
                    max = count;
                    max2 = startCount;
                }
            }
            else
            {
                count = 0;
            }
        }

        for (int i = max2; i <= (max2 + max); i++)
        {
            result.Add(numbers[i]);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}