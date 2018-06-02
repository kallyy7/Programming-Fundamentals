using System;
using System.Linq;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int br = 0;
            int count = 0;
            int max = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count++;
                    if (count > max)
                    {
                        br = i - count;
                        max = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            for (int i = br + 1; i <= br + max + 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
