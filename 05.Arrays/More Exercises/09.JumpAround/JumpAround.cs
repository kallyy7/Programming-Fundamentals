using System;
using System.Linq;

public class JumpAround
{
    public static void Main()
    {
        var numArray = Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .ToArray();

        int i = 0;
        int sum = 0;

        while (i >= 0)
        {
            if (i < numArray.Length)
            {
                sum += numArray[i];
                i = i + numArray[i] < numArray.Length ?
                    i + numArray[i] : i - numArray[i];
            }
        }

        Console.WriteLine(sum);
    }
}