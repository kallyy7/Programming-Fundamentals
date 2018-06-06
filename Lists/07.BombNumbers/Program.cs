﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = bombInfo[0];
            int power = bombInfo[1];

            while (numbers.Contains(bomb))
            {
                int bombIndex = numbers.IndexOf(bomb);
                int elementsOnRight = Math.Min(power, numbers.Count - 1 - bombIndex);
                int elementsOnLeft = Math.Min(bombIndex, power);
                int startIndex = Math.Max(bombIndex - power, 0);
                numbers.RemoveRange(startIndex, elementsOnLeft + 1 + elementsOnRight);
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
