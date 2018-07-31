using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> time = Console.ReadLine().Split().ToList();

            time.Sort();
           
            Console.WriteLine(string.Join(", ", time));           
        }
    }
}
