using System;
using System.Collections.Generic;
using System.Linq;

public class PokemonDontGo
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        List<int> removedElements = new List<int>();

        while (true)
        {
            int index = int.Parse(Console.ReadLine());
            int current = 0;
            int removedNumber = 0;

            if (index > numbers.Count - 1)
            {
                removedNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Add(removedNumber);
                removedElements.Add(removedNumber);
                current = numbers[0];
            }
            else if (index < 0)
            {
                removedNumber = numbers[0];
                numbers.RemoveAt(0);
                removedElements.Insert(0, numbers[numbers.Count - 1]);
                removedElements.Add(removedNumber);
                current = numbers[0];
            }
            else
            {
                current = numbers[index];
                removedElements.Add(current);
                numbers.RemoveAt(index);
            }

            if (numbers.Count.Equals(0))
            {
                break;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > current)
                {
                    numbers[i] -= current;
                }
                else
                {
                    numbers[i] += current;
                }
            }
        }

        Console.WriteLine(removedElements.Sum());
    }
}