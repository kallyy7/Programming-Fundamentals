using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int skip = input[0];
            int take = input[1];

            string input2 = Console.ReadLine();
            string pattern = @"(?<=\|<.{" + skip + "})([^|]{0," + take + "})";
            MatchCollection words = Regex.Matches(input2, pattern);

            Console.WriteLine(string.Join(", ", words));

        }
    }
}
