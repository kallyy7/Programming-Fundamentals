using System;
using System.Linq;

namespace _02.RotateAndSumSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            int[] sumOfArrays = new int[numberArray.Length];

            for (int i = 0; i < rotation; i++)
            {
                RotateArray(numberArray);

                for (int j = 0; j < sumOfArrays.Length; j++)
                {
                    sumOfArrays[j] += numberArray[j];
                }
            }
            Console.WriteLine(string.Join(" ", sumOfArrays));
        }

        private static void RotateArray(int[] numberArray)
        {
            int lastElement = numberArray[numberArray.Length - 1];
            for (int j = numberArray.Length - 1; j > 0; j--)
            {
                numberArray[j] = numberArray[j - 1];
            }
            numberArray[0] = lastElement;
        }
    }
}


