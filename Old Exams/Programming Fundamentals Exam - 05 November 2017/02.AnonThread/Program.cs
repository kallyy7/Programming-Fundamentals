using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.AnonThread
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string[] commands = Console.ReadLine().Split();

            while (!commands[0].Equals("3:1"))
            {                          
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);
                string concatWord = null;

                if (endIndex >= input.Count - 1)
                {
                    endIndex = input.Count - 1;
                }

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                if (commands[0].Equals("merge"))
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concatWord += input[i];
                    }
                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
                    input.Insert(startIndex, concatWord);

                }
                else if (commands[0].Equals("divide"))
                {
                    List<string> divided = new List<string>();
                    int divide = int.Parse(commands[2]);
                    string word = input[startIndex];
                    input.RemoveAt(startIndex);
                    int parts = word.Length / divide;
                    for (int i = 0; i < divide; i++)
                    {
                        string element = word.Substring(0, parts);
                        word = word.Substring(parts);
                        divided.Add(element);
                    }
                    input.InsertRange(startIndex, divided);
                }
                commands = Console.ReadLine().Split();

            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
