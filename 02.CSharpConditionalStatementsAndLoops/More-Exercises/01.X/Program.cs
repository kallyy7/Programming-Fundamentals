using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = -(x / 2); i <= x / 2; i++)
            {

                if (i == 0)
                {
                    Console.WriteLine("{0}x", new string(' ', x / 2));
                }
                else
                {
                    Console.WriteLine("{0}x{1}x",

                   new string(' ', Math.Abs(x / 2 - Math.Abs(i))),

                   new string(' ', Math.Abs(i * 2) - 1));
                }
            }
        }
    }
}
