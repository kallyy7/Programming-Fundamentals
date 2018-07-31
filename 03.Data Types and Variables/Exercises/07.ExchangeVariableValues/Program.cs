using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Console.Write($"Before:\na = {first}\nb = {second}\n");
            int temp = first;
            first = second;
            second = temp;
            Console.WriteLine($"After:\na = {first}\nb = {second}\n");
        }
    }
}
