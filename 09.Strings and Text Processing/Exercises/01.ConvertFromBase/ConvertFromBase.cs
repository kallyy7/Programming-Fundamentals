using System;
using System.Numerics;
using System.Text;

public class ConvertFromBase
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int @base = int.Parse(input[0]);
        BigInteger number = BigInteger.Parse(input[1]);

        StringBuilder converted = new StringBuilder();

        while (number > 0)
        {
            BigInteger remainder = number % @base;
            converted.Append(remainder);
            number /= @base;
        }

        for (int i = converted.Length - 1; i >= 0; i--)
        {
            Console.Write(converted[i]);
        }

        Console.WriteLine();
    }
}