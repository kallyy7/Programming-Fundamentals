using System;
using System.Collections.Generic;

namespace _04.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> num = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                if(IsPrime(i) == true)
                {
                    num.Add(i);
                }              
            }

            Console.WriteLine(string.Join(" ", num));
        }
        static bool IsPrime(int i)
        {
            var a = (int)Math.Floor(Math.Sqrt(i));

            for (int j = 2; j <= a; ++j)
            {
                if (i % j == 0 || i == 0 || i == 1) return false;
            }

            return true;
        }
    }
}
