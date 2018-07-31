using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
            
        }
        static bool IsPrime(long number)
        {
            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            var a = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= a; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
