using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string hex = number.ToString("X");
            string binary = Convert.ToString(number, 2).ToUpper();

            Console.WriteLine($"{hex}\n{binary}");
        }
    }
}
