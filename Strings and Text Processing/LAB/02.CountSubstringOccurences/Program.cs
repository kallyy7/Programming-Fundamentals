using System;
using System.Linq;

namespace _02.CountSubstringOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string searchWord = Console.ReadLine().ToLower();
            int counter = 0;
            int searchResult = input.IndexOf(searchWord);

            while (!searchResult.Equals(-1))
            {
                counter++;
                searchResult = input.IndexOf(searchWord, searchResult +1);
            }


            Console.WriteLine(counter);
        }
    }
}
