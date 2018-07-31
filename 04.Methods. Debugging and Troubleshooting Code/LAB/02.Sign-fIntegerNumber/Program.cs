using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SignОfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
        static void PrintSign(int n)
        {
            string sign = "zero";
            if (n > 0)
            {
                sign = "positive";
            }
            else if (n < 0)
            {
                sign = "negative";
            }
            Console.WriteLine($"The number {n} is {sign}.");
        }
    }
}
