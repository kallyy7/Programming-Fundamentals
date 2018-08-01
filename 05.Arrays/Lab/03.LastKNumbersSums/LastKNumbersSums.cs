using System;
using System.Collections.Generic;
using System.Linq;

public class LastKNumbersSums
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        long sum = 0;
        long[] arr = new long[n];
        arr[0] = 1;

        for (int i = 1; i < n; i++)
        {
            for (int j = k; j > 0; j--)
            {
                if (i - j >= 0)
                {
                    sum += arr[i - j];
                }
                arr[i] = sum;
            }
        }

        Console.WriteLine(string.Join(" ", arr));
    }
}