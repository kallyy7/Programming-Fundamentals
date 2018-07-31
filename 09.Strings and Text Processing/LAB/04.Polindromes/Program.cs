using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Polindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ,!?.".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> result = new List<string>();

            foreach (var word in input)
            {

                if (word[0].Equals(word[word.Length - 1]))
                {
                    result.Add(word);
                }
            }

            result.Sort();
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
