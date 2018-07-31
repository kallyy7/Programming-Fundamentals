using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<string> command = Console.ReadLine().Split().ToList();

            while (!command[0].Equals("print"))
            {
                if (command[0].Equals("add"))
                {
                    int index = int.Parse(command[1]);
                    int element = int.Parse(command[2]);
                    numbers.Insert(index, element);
                }
                else if (command[0].Equals("addMany"))
                {
                    AddMany(command, numbers);
                }
                else if (command[0].Equals("contains"))
                {
                    int element = int.Parse(command[1]);
                    Console.WriteLine(numbers.IndexOf(element));
                }
                else if (command[0].Equals("remove"))
                {
                    int index = int.Parse(command[1]);
                    numbers.RemoveAt(index);
                }
                else if (command[0].Equals("shift"))
                {
                    int shiftElement = int.Parse(command[1]);
                    int element = numbers.IndexOf(shiftElement);
                    int lastindex = numbers.Count;
                    numbers.Insert(numbers[lastindex-1], shiftElement);
                    numbers.RemoveAt(element);
                }
                else if (command[0].Equals("sumPairs"))
                {
                    sumPairs(numbers);
                }

                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
        static void AddMany(List<string> command, List<int> numbers)
        {
            int index = int.Parse(command[1]);
            for (int i = 1; i <= index; i++)
            {
                int add = int.Parse(command[i]);
                numbers.Add(add);
            }
        }
        static void sumPairs(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);

            }
        }
    }
}
