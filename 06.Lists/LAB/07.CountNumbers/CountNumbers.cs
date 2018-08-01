using System;
using System.Collections.Generic;
using System.Linq;

public class CountNumbers
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        var nums = new List<int>();
        inputNumbers.Sort();
        int count = 0;
       
        for (int i = 0; i < inputNumbers.Count; i++)
        {
            int current = inputNumbers[i];

            if (!nums.Contains(inputNumbers[i]))
            {
                for (int j = 0; j < inputNumbers.Count; j++)
                {
                    if (current == inputNumbers[j])
                    {
                        count++;
                    }
                    nums.Add(inputNumbers[i]);
                }

                Console.WriteLine($"{current} -> {count}");
            }
        }
    }
}