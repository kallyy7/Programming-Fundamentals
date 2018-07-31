using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int maxSumBoundary = int.Parse(Console.ReadLine());
            int sum = 0;
            int br = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int y = 1; y <= M; y++)
                {
                    sum += 3 * (i * y);
                    br += 1;
                    if (sum >= maxSumBoundary)
                    {
                        Console.WriteLine($"{br} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSumBoundary}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{br} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
