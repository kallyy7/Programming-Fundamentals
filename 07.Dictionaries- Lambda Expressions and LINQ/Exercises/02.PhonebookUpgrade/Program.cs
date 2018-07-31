using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0].Equals("ListAll"))
                {
                    foreach (var contact in phonebook)
                    {
                        if (contact.Value == null)
                        {
                            Console.WriteLine("Contact {0} does not exist.", contact.Key);
                        }
                        else
                        {
                            Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
                        }
                    }

                }
                else if (command[0].Equals("END"))
                {
                    break;
                }

                if (command[0].Equals("A"))
                {
                    string name = command[1];
                    string phoneNumber = command[2];

                    phonebook[name] = phoneNumber;
                    //phonebook.Add(name, phoneNumber);
                }
                else if (command[0].Equals("S"))
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
