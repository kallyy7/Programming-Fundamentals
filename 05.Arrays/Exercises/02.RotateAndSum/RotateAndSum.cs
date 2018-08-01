using System;
using System.Linq;

public class RotateAndSum
{
    public static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int[] sum = new int[arr.Length];
        int rotations = int.Parse(Console.ReadLine());

        for (int i = 0; i < rotations; i++)
        {
            int[] rotated = new int[arr.Length];
            rotated[0] = arr[arr.Length - 1];

            for (int j = 1; j < rotated.Length; j++)
            {
                rotated[j] = arr[j - 1];
            }

            for (int j = 0; j < sum.Length; j++)
            {
                sum[j] += rotated[j];
            }
            arr = rotated;
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}