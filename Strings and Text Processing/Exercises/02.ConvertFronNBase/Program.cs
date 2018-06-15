using System;
using System.Numerics;

namespace _02.ConvertFronNBase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int @base = int.Parse(input[0]);
            string number = input[1];

            BigInteger sum = 0;
            int pow = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                char curr = number[i];
                int currentNumber = int.Parse(curr.ToString());

                BigInteger currentSum = currentNumber * BigInteger.Pow(@base, pow);
                sum += currentSum;
                pow++;
            }

            Console.WriteLine(sum);
        }
    }
}
