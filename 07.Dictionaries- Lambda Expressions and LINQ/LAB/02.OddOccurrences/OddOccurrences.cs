using System;
using System.Collections.Generic;
using System.Linq;

public class OddOccurrences
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .ToLower()
            .Split()
            .ToArray();

        var words = new Dictionary<string, int>();

        foreach (var item in input)
        {
            if (!words.ContainsKey(item))
            {
                words.Add(item, 1);
            }
            else
            {
                words[item]++;
            }
        }

        var oddCount = new List<string>();

        foreach (var kvp in words)
        {
            if (kvp.Value % 2 != 0)
            {
                oddCount.Add(kvp.Key);
            }
        }

        Console.WriteLine(string.Join(", ", oddCount));
    }
}