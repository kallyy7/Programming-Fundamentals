using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PrimesGivenRa
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            FindPrimesInRange(startNum, endNum);
        }
        static void FindPrimesInRange(int startNum, int endNum)
        {
            if (startNum > endNum)
            {
                Console.WriteLine("(empty list)");
            }
            else
            {
                List<long> integers = new List<long>();

                for (long i = startNum; i <= endNum; i++)
                {
                    bool Prime = true;
                    if (i == 0 || i == 1) { Prime = false; }
                    for (long numberToDivideBy = 2; numberToDivideBy <= Math.Sqrt(i); numberToDivideBy++)
                    {
                        if ((double)i % numberToDivideBy == 0) { Prime = false; break; }
                    }
                    if (Prime == true) { integers.Add(i); }
                }

                Console.WriteLine(string.Join(", ", integers));
            }
        }
    }
}
