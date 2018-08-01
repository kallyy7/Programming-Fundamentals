using System;
using System.Linq;

public class GrabAndGo
{
    public static void Main()
    {
        long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long searchNumber = long.Parse(Console.ReadLine());
        int counter = 0;
        long sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchNumber)
            {
                counter++;

                if (counter == 2)
                {
                    break;
                }
                sum += numbers[i];
            }
            else
            {
                sum += numbers[i];
            }
        }

        if (counter == 2)
        {
            Console.WriteLine("No occurrences were found!");
        }
        else
        {
            Console.WriteLine(sum);
        }
    }
}