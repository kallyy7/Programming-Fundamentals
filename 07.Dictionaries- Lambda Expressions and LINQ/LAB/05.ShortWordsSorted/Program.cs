using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]{'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};
            string word = Console.ReadLine().ToLower();
            string[] words = word.Split(separators);

            var result = words
            .Where(w => w != "")
            .Where(w => w.Length < 5)
            .OrderBy(w => w).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
