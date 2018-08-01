using System;
using System.Collections.Generic;
using System.Linq;

public class AppendLists
{
    public static void Main()
    {
        var inputArr = Console.ReadLine()
            .Split('|')
            .ToArray()
            .Reverse();
        var newList = new List<string>();

        foreach (var token in inputArr)
        {
            string[] numbers = token.Split();

            foreach (var item in numbers)
            {
                if (!item.Equals(" "))
                {
                    newList.Add(item);
                }
            }
        }

        Console.WriteLine(string.Join(" ", newList));
    }
}