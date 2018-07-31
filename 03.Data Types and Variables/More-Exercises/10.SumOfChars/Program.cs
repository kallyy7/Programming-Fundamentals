using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char curr = char.Parse(Console.ReadLine());
                sum += curr;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
