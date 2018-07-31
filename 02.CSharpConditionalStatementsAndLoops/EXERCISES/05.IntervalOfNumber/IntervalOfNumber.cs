using System;
using System.Collections.Generic;

public class IntervalOfNumber
{
    public static void Main()
    {
        int[] numbers = new int[2];
        numbers[0] = int.Parse(Console.ReadLine());
        numbers[1] = int.Parse(Console.ReadLine());

        int smallest = numbers.Min();
        int biggest = numbers.Max();

        for (int i = smallest; i <= biggest; i++)
        {
            Console.WriteLine(i);
        }
    }
}