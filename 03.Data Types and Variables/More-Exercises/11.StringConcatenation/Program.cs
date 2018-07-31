using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimeter = Console.ReadLine();
            string oddOrEven = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            string sum = null;

            for (int i = 0; i < counter; i++)
            {
                string curr = Console.ReadLine();

                if (oddOrEven == "even" && i % 2 == 1)
                {
                    sum += curr + delimeter;
                }
                else if (oddOrEven == "odd" && i % 2 == 0)
                {
                    sum += curr + delimeter;
                }
            }

            Console.WriteLine(sum.Remove(sum.Length - 1, 1));
        }
    }
}
