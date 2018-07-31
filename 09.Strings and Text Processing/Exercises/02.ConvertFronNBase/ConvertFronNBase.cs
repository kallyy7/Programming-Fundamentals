using System;
using System.Numerics;

public class ConvertFronNBase
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int @base = int.Parse(input[0]);
        string number = input[1];
        BigInteger sum = 0;
        int pow = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            char current = number[i];
            int currentNumber = int.Parse(current.ToString());
            BigInteger currentSum = currentNumber * BigInteger.Pow(@base, pow);
            sum += currentSum;
            pow++;
        }

        Console.WriteLine(sum);
    }
}