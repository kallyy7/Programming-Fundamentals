using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
           
            if((num2 - num1) < 5)
            {
                Console.WriteLine("No");
            }

            for (int i = num1; i <= num2 - 4; i++)
            {
                for (int j = num1 + 1; j <= num2 - 3; j++)
                {
                    for (int k = num1 + 2; k <= num2 - 2; k++)
                    {
                        for (int l = num1 + 3; l <= num2 - 1; l++)
                        {
                            for (int m = num1 + 4; m <= num2; m++)
                            {
                                if (i < j && j < k && k < l && l < m)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
