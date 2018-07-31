using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _06.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            int maxLen = Math.Max(firstNumber.Length, secondNumber.Length);

            firstNumber = firstNumber.PadLeft(maxLen + 1, '0');
            secondNumber = secondNumber.PadLeft(maxLen + 1, '0');

            int[] firstDigits = firstNumber.Select(x => int.Parse(x.ToString())).ToArray();
            int[] secondDigits = secondNumber.Select(x => int.Parse(x.ToString())).ToArray();
            int[] sum = new int[firstNumber.Length];

            int currentSum = 0;

            for (int i = sum.Length - 1; i >= 0; i--)
            {
                int total = firstDigits[i] + secondDigits[i] + currentSum;
                sum[i] = total % 10;

                currentSum = (total > 9) ?  1 : 0;
               
            }

            string result = string.Join(string.Empty, sum.SkipWhile(x => x == 0));

            Console.WriteLine(result);
        }
    }
}
