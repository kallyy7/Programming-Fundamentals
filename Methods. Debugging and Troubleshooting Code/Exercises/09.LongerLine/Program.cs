using System;

namespace _09.LongerLine
{
    class Program
    {
        static void Main(string[] args)  
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double otherX1 = double.Parse(Console.ReadLine());
            double otherY1 = double.Parse(Console.ReadLine());
            double otherX2 = double.Parse(Console.ReadLine());
            double otherY2 = double.Parse(Console.ReadLine());

            double first = LongerLine(x1, y1, x2, y2);
            double second = LongerLine(otherX1, otherY1, otherX2, otherY2);

            if (first >= second)
            {
                CenterPoint(x1, y1, x2, y2);
            }
            else
            {
                CenterPoint(otherX1, otherY1, otherX2, otherY2);
            }
        }
        static double LongerLine(double x1, double y1, double x2, double y2)
        {
            double sum = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return sum;
 
        }
        static void CenterPoint(double x1, double y1, double x2, double y2)
        {
            double first = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double second = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (first <= second)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
