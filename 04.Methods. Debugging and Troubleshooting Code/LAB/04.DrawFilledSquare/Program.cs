using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopRows(n);
            MiddleRow(n);
            BottomRows(n);
        }
        static void TopRows(int n)
        {        
            Console.WriteLine($@"{new string('-', n * 2)}");               
        }
        static void MiddleRow(int n)
        {
            string V = "\\/";
            for (int a = 1; a < n - 1; a++)
            {
                V += "\\/";
            }
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine($"-{V}-");
            }
        }
        static void BottomRows(int n) { 
            Console.WriteLine($@"{new string('-', n * 2)}");
        }
    }
}
