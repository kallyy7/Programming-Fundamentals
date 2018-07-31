using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long SecoundNnumber = long.Parse(Console.ReadLine());

            long a = Math.Min(firstNumber, SecoundNnumber);
            long b = Math.Max(firstNumber, SecoundNnumber);
            long sum = a * 4 + b * 10;

            Console.WriteLine(sum);
        }
    }
}
