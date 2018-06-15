using System;
using System.Numerics;
using System.Text;

namespace _01.ConvertFromBase
{
    class Program
    {
        static void Main(string[] args)
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
}
