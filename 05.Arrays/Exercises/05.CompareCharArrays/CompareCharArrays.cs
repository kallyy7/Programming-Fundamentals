﻿using System;
using System.Linq;

public class CompareCharArrays
{
    public static void Main()
    {
        char[] first = Console.ReadLine()
            .Split()
            .Select(char.Parse)
            .ToArray();
        char[] second = Console.ReadLine()
            .Split()
            .Select(char.Parse)
            .ToArray();

        int shorterArray = Math.Min(first.Length, second.Length);

        if (first.Length == second.Length)
        {
            if (first[0] > second[0])
            {
                Console.WriteLine(string.Join("", second));
                Console.WriteLine(string.Join("", first));
            }
            else
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
        }

        else if (first.Length == shorterArray)
        {
            Console.WriteLine(string.Join("", first));
            Console.WriteLine(string.Join("", second));
        }
        else
        {
            Console.WriteLine(string.Join("", second));
            Console.WriteLine(string.Join("", first));
        }
    }
}