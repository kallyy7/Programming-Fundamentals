using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string htmlText = Console.ReadLine();
            string pattern = @"<p>(.+?)<\/p>";

            string currentMach = string.Empty;

            foreach (Match match in Regex.Matches(htmlText, pattern))
            {
                currentMach += match.Groups[1].Value;
            }

            currentMach = Regex.Replace(currentMach, @"[^a-z\d]", " ");
            currentMach = Regex.Replace(currentMach, @"\s+|\n+", " ");
            StringBuilder result = new StringBuilder(currentMach.Length);

            foreach (var ch in currentMach)
            {
                if (ch >= 'a' && ch <= 'm')
                {
                    result.Append((char)(ch + 13));
                }
                else if (ch >= 'n' && ch <= 'z')
                {
                    result.Append((char)(ch - 13));
                }
                else
                {
                    result.Append(ch);
                }
            }

            Console.WriteLine(result);
        }
    }
}
