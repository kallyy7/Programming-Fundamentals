using System;
using System.Linq;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            FoldAndSum(numbers);
        }
        static void FoldAndSum(int[] numbers)
        {
            int[] left = new int[numbers.Length / 4];
            int[] right = new int[numbers.Length / 4];
            int[] upper = new int[numbers.Length / 2];
            int[] down = new int[numbers.Length / 2];
            int[] sum = new int[numbers.Length / 2];

            int rev = numbers.Length / 4 - 1;
            int a = numbers.Length - 1;
            int b = numbers.Length / 4;

            for (int i = 0; i <= (numbers.Length / 4) - 1; i++)
            {
                left[i] = numbers[rev];
                right[i] = numbers[a];
                rev--;
                a--;

            }

            upper = left.Concat(right).ToArray();

            for (int i = 0; i < numbers.Length / 2; i++, b++)
            {
                down[i] = numbers[b];
            }
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                sum[i] += (upper[i] + down[i]);
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
