using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double converted = 0;
            string metricUnit = null;

            switch (imperialUnit)
            {
                case "miles":
                    converted = value * 1.6;
                    metricUnit = "kilometers";
                    break;
                case "inches":
                    converted = value * 2.54; metricUnit = "centimeters";
                    break;
                case "feet":
                    converted = value * 30; metricUnit = "centimeters";
                    break;
                case "yards":
                    converted = value * 0.91; metricUnit = "meters";
                    break;
                case "gallons":
                    converted = value * 3.8; metricUnit = "liters";
                    break;
            }
            Console.WriteLine($"{value} {imperialUnit} = {converted:f2} {metricUnit}");
        }
    }
}
