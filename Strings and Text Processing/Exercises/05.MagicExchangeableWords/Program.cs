using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] token = input.Split();
            string first = token[0];
            string second = token[1];

            var isEqual = CompareStrings(first, second);

            Console.WriteLine(isEqual);
        }

        static string CompareStrings(string firstString, string secondString)
        {
            var dict = new Dictionary<char, char>();
            string result = "true";
            int minLenght = Math.Min(firstString.Length, secondString.Length);
            int maxLenght = Math.Max(firstString.Length, secondString.Length);
            string minString = null;
            string maxString = null;
            if (firstString.Length > secondString.Length)
            {
                maxString = firstString;
                minString = secondString;
            }
            else if (firstString.Length < secondString.Length)
            {
                maxString = secondString;
                minString = firstString;
            }
            else
            {
                minString = firstString;
                maxString = secondString;
            }

            for (int i = 0; i < minLenght; i++)
            {
                if (!dict.ContainsKey(maxString[i]))
                {
                    dict[maxString[i]] = minString[i];
                }
                else if (dict[maxString[i]] != minString[i])
                {
                    result = "false";
                    return result;
                }
            }

            for (int i = minLenght; i < maxLenght; i++)
            {
                if (!dict.ContainsKey(maxString[i]))
                {
                    result = "false";
                    break;
                }
            }
            return result;
        }
    }
}
