using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NumInReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = (Console.ReadLine());
            string reversed = ReverseNum(number);
            Console.WriteLine(reversed);
        }

        static string ReverseNum(string number)
        {
            string result = null;
            for (int i = number.Length-1; i >= 0; i--)
            {
                result += number[i];
            }
            return result;
        }
    }
}
