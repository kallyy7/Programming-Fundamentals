using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ,!?.".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> palindromes = new List<string>();

            foreach (var word in words)
            {
                bool isPalindrome = isPalindrom(word);

                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            var sorted = palindromes.Distinct().OrderBy((w => w));

            Console.WriteLine(string.Join(", ",sorted));
        }

        static bool isPalindrom(string word)
        {
            string reversed = new string(word.Reverse().ToArray());

            return string.Equals(reversed, word);

        }
    }
}
