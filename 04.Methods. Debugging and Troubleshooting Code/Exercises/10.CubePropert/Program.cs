using System;

namespace _10.CubePropert
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string shape = Console.ReadLine();

            double result = CubeProperties(cubeSide, shape);

            Console.WriteLine($"{result:f2}");
        }

        static double CubeProperties(double a, string shape)
        {
            double properties = 0;

            switch (shape)
            {
                case "volume":
                    properties = a * a * a;
                    break;
                case "space":
                    properties = Math.Sqrt(3 * a * a);
                    break;
                case "area":
                    properties = 6 * a * a;
                    break;
                case "face":
                    properties = Math.Sqrt(2 * a * a);
                    break;
            }
            return properties;
        }
    }
}
