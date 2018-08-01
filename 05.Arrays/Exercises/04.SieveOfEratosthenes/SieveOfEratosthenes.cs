using System;
using System.Collections.Generic;

public class SieveOfEratosthenes
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        List<int> num = new List<int>();

        for (int i = 2; i <= inputNumber; i++)
        {
            if (IsPrime(i))
            {
                num.Add(i);
            }
        }

        Console.WriteLine(string.Join(" ", num));
    }
    private static bool IsPrime(int i)
    {
        int num = (int)Math.Floor(Math.Sqrt(i));

        for (int j = 2; j <= num; ++j)
        {
            if (i % j == 0 || i == 0 || i == 1) return false;
        }

        return true;
    }
}