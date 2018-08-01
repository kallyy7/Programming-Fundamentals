using System;
using System.Collections.Generic;
using System.Linq;

public class SumAdjacentEqualNumbers
{
    public static void Main()
    {
        var numbers = new List<double>();
        var input = Console.ReadLine()
            .Split()
            .ToList();

        for (int i = 0; i < input.Count; i++)
        {
            numbers.Add(double.Parse(input[i]));
        }

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            while (i < numbers.Count - 1)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);

                    if (i > 0)
                    {
                        i--;
                    }
                }
                else
                {
                    i++;
                }

            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}