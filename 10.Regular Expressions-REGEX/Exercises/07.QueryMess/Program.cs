using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07.QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPattern = @"([^&=?]*)=([^&=?]*)";
            string secondPattern = @"((%20|\+)+)";
            string input = Console.ReadLine();

            while (!input.Equals("END"))
            {
                Regex pairs = new Regex(firstPattern);
                var matches = pairs.Matches(input);
                Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();

                for (int i = 0; i < matches.Count; i++)
                {
                    var field = matches[i].Groups[1].Value;
                    field = Regex.Replace(field, secondPattern, word => " ").Trim();

                    var value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, secondPattern, word => " ").Trim();

                    if (!results.ContainsKey(field))
                    {
                        results.Add(field, new List<string>());
                    }

                    results[field].Add(value);
                }

                input = Console.ReadLine();
            }
            foreach (var pair in results)
            {
                Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
            }

            Console.WriteLine();
        }
    }
}
