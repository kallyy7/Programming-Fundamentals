using System;
using System.Linq;

public class TripleSum
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int sum = numbers[i] + numbers[j];

                if (numbers.Contains(sum))
                {
                    Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                    counter++;
                }
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("No");
        }

    }
}