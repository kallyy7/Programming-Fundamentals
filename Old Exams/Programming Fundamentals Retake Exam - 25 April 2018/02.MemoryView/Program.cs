using System;
using System.Collections.Generic;
using System.Linq;

namespace _02MemoryView
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = null;
          
            List<string> names = new List<string>();

            while (!input.Equals("Visual Studio crash"))
            {
                result += input + " ";
                input = Console.ReadLine();
            }

            string[] token = result.Split();

            for (int i = 0; i < token.Length - 5; i++)
            {
                bool startString = (token[i] == "32656") && (token[i + 1] == "19759") && (token[i + 2] == "32763") && (token[i + 3] == "0") && (token[i + 5] == "0");

                if (startString)
                {
                    string word = null;
                    int wordLength = int.Parse(token[i + 4]);

                    for (int j = i + 6; j <= (i + 6) + wordLength; j++)
                    {
                        word += (char)(int.Parse(token[j]));
                    }
                    names.Add(word);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
