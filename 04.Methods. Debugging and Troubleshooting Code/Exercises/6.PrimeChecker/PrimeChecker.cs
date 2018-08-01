using System;

public class PrimeChecker
{
    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(number));
    }
    private static bool IsPrime(long number)
    {
        if (number == 0) return false;
        if (number == 1) return false;
        if (number == 2) return true;

        int a = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 2; i <= a; ++i)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}