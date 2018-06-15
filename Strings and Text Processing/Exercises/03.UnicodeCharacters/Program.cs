using System;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {

                Console.Write("\\u{0:x4}", (int)input[i]);
            }
            Console.WriteLine();
            
        }
    }
}
