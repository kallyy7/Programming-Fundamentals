using System;
using System.Linq;

namespace _07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().
                                  Split(' ').
                           Select(int.Parse).ToArray();
            int[] secondLine = Console.ReadLine().
                                  Split(' ').
                           Select(int.Parse).ToArray();
            int a = 0;
            int b = 0;
            int max = Math.Max(firstLine.Length, secondLine.Length);

            for (int i = 0; i < max; i++)
            {
                if (a >= firstLine.Length)
                {
                    a = 0;
                }
                if (b >= secondLine.Length)
                {
                    b = 0;
                }

                int sum = firstLine[a] + secondLine[b];
                Console.Write($"{sum} ");
                a++;
                b++;


            }
            Console.WriteLine();
        }
    }
}

