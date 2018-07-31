using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(w, h);
            Console.WriteLine(area);
        }
        static double  GetTriangleArea(double w, double h)
        {
            return w * h / 2;
        }
    }
}
