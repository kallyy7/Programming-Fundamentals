using System;
using System.Linq;

namespace _06.ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split();
            string[] reversed = new string [n.Length];
            int br = 0;

            for (int i = n.Length - 1; i >= 0 ; i--)
            {
                reversed[br] += n[i];
                br++;
            }
            Console.WriteLine(string.Join (" " ,reversed));
        }
    }
}
