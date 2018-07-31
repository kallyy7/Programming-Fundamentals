using System;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string input = Console.ReadLine();
            var numbers = Regex.Matches(input, pattern);

            foreach (Match n in numbers)
            {
                Console.Write(n.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
