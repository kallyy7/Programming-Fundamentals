using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0].Equals("END"))
                {
                    break;
                }
                if (command[0].Equals("A"))
                {
                    string name = command[1];
                    string phoneNumber = command[2];

                    phonebook[name] = phoneNumber; 
                }
                if (command[0].Equals("S"))
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine("{0} -> {1}", command[1], phonebook[command[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", command[1]);
                    }
                }
            }
        }
    }
}
