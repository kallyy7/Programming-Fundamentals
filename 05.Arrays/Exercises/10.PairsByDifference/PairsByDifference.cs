using System;
using System.Linq;

public class PairsByDifference
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int difference = int.Parse(Console.ReadLine());

        GetPairsByDifference(numbers, difference);
    }
    private static void GetPairsByDifference(int[] numbers, int difference)
    {
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if ((numbers[i] - numbers[j]) == difference)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}