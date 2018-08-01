using System;
using System.Collections.Generic;
using System.Linq;

class ReverseArrayОfIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] reversedNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            reversedNumbers[i] = int.Parse(Console.ReadLine());
        }
        reversedNumbers = reversedNumbers.Reverse().ToArray();

        Console.WriteLine(string.Join(" ", reversedNumbers));
    }
}