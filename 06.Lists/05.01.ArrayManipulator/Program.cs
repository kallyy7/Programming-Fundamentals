using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._01.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse).ToList();
            while (true)
            {


                List<string> commands = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                if (commands[0] == "add")
                {
                    int index = int.Parse(commands[1]);
                    int element = int.Parse(commands[2]);
                    numbers.Insert(index, element);


                }
                else if (commands[0] == "addMany")
                {
                    for (int i = 0; i < commands.Count - 2; i++)
                    {
                        int index = int.Parse(commands[1]);
                        int element = int.Parse(commands[2]);


                        numbers.Insert(index + i, int.Parse(commands[2 + i]));

                    }
                }
                else if (commands[0] == "contains")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (int.Parse(commands[1]) == numbers[i])
                        {
                            Console.WriteLine(i);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("-1");
                            break;
                        }
                    }
                }
                else if (commands[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commands[1]));
                }
                else if (commands[0] == "shift")
                {
                    int position = int.Parse(commands[1]);
                    List<int> newList = numbers.Take(position).ToList();

                    for (int i = 0; i < newList.Count; i++)
                    {

                        numbers.Add(newList[i]);
                    }
                    numbers = numbers.Skip(position).ToList();
                }
                else if (commands[0] == "sumPairs")
                {
                    List<int> sumList = new List<int>();
                    for (int i = 0; i < numbers.Count; i += 2)
                    {

                        sumList.Add(numbers[i] + numbers[i + 1]);

                    }
                    numbers = sumList;
                }
                else if (commands[0] == "print")
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", numbers));
                    Console.Write("]");

                    return;
                }
            }
        }
    }
}
