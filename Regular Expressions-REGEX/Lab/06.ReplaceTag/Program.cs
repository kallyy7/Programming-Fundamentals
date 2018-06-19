using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.ReplaceTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"<a.*?href=(.*?)>(.*?)<\/a>";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {




                regex.Replace(input, item.ToString());
                string replace = @"[URL href=" + item.Groups[1] + "]" + item.Groups[2] + "[/URL]";
                Console.WriteLine(Regex.Replace(input, pattern, replace));
            }
        }
    }
}
