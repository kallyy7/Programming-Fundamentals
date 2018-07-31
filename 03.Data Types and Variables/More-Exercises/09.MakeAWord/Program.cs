using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string word = null;

            for (int i = 1; i <= number; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                word += letter;
            }

            Console.Write($"The word is: {word}");
        }
    }
}
