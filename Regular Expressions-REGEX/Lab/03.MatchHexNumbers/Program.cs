using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MatchHexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            var input = Console.ReadLine();
            var numbers = Regex.Matches(input, pattern)
                .Select(n => n.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
