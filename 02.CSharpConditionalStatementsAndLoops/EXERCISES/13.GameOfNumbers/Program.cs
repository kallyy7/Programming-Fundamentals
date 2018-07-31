using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int br = 0;

            for (int i = N; i <= M; i++)
            {
                for (int y = N; y <= M; y++)
                {
                    br += 1;
                    if ((i + y) == magicalNumber)
                    {
                        Console.WriteLine($"Number found! {y} + {i} = {magicalNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{br} combinations - neither equals {magicalNumber}");
        }
    }
}
