using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = PowerNumber(number, power);
            Console.WriteLine(result);
        }
        static double PowerNumber(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
