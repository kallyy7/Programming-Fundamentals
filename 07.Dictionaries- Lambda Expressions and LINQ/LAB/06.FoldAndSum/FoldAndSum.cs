using System;
using System.Linq;

public class FoldAndSum
{
    public static void Main()
    {
        int[] inputArr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int k = inputArr.Length / 4;

        int[] row1left = inputArr
            .Take(k)
            .Reverse()
            .ToArray();
        int[] row1right = inputArr
            .Reverse()
            .Take(k)
            .ToArray();
        int[] row1 = row1left
            .Concat(row1right)
            .ToArray();
        int[] row2 = inputArr
            .Skip(k)
            .Take(2 * k)
            .ToArray();

        var sumArr = row1.Select((x, index) => x + row2[index]);

        Console.WriteLine(string.Join(" ", sumArr));
    }
}
