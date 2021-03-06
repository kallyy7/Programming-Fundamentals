﻿using System;

public class MultiplyEvensByOdds
{
    public static void Main()
    {
        int n = Math.Abs(int.Parse(Console.ReadLine()));

        Console.WriteLine(GetMultipleOfEvensAndOdds(n));
    }
    private static int GetMultipleOfEvensAndOdds(int n)
    {
        int sumEvens = GetSumEvenDigits(n);
        int sumOdds = GetSumOfOddDigits(n);
        return sumEvens * sumOdds;
    }
    private static int GetSumOfOddDigits(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int LastDigit = n % 10;

            if (LastDigit % 2 != 0)
            {
                sum += LastDigit;
            }
            n /= 10;
        }
        return sum;
    }
    private static int GetSumEvenDigits(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int LastDigit = n % 10;

            if (LastDigit % 2 == 0 && LastDigit != 1)
            {
                sum += LastDigit;
            }
            n /= 10;
        }
        return sum;
    }
}