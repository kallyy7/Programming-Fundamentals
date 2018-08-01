using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        var nums = new List<double>();
        numbers.Sort();

        for (int i = 0; i < numbers.Count; i++)
        {
            double current = numbers[i];
            int count = 0;

            if (!nums.Contains(numbers[i]))
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (current == numbers[j])
                    {
                        count++;
                    }
                    nums.Add(numbers[i]);
                }

                Console.WriteLine($"{current} -> {count}");
            }
        }
    }
}
