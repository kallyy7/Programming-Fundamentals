using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        { 
            string  pattrern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection machesNames = Regex.Matches(names, pattrern);

            foreach (Match name in machesNames)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();

        }
    }
}
