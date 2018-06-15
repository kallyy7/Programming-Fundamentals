using System;

namespace _01.ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] reverse = input.ToCharArray();

            Array.Reverse(reverse);

            Console.WriteLine(reverse);
        }
    }
}
