using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsium = FahrenheitToCelsium(fahrenheit);
            Console.WriteLine($"{celsium:F2}");
        }
        static double FahrenheitToCelsium(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }      
    }
}
