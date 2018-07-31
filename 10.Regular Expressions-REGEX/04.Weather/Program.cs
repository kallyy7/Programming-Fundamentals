using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, SortedDictionary<string, string>> cities = new SortedDictionary<string, SortedDictionary<string, string>>();
            string pattern = @"([A-Z]{2})(\d{2}.\d{2})([A-Za-z]+[|])";

            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    var city = match.Groups[1].Value;
                    var temp = match.Groups[2].Value;
                    var typeOfWeather = match.Groups[3].Value;

                    if (!cities.ContainsKey(city))
                    {
                        cities[city] = new SortedDictionary<string, string>();
                        cities[city].Add(temp, typeOfWeather);
                    }
                }

                input = Console.ReadLine();
            }

        
            foreach (var d in cities)
            {
                Console.Write($"{d.Key} => ");
                foreach (var item in d.Value)
                {
                    Console.WriteLine($"{item.Key} => {item.Value}");
                }
            }
        }
    }
}
