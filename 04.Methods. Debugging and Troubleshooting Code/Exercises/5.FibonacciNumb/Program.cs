using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FibonacciNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fibonnaci(n);
        }
        static void Fibonnaci (int n)
        {
            int a = 0;
            int b = 1; 

            for (int i = 0; i < n ; i++)

            {
                int temp = a + b;              
                a = b;
                b = temp;
            }
            Console.WriteLine($"{b}");
        }
    }
}
