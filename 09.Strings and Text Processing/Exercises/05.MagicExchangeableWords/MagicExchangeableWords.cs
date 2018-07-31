using System;
using System.Collections.Generic;

public class MagicExchangeableWords
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] token = input.Split();
        string first = token[0];
        string second = token[1];
        string isEqual = CompareStrings(first, second);

        Console.WriteLine(isEqual);
    }

    static string CompareStrings(string firstString, string secondString)
    {
        var words = new Dictionary<char, char>();
        string result = "true";
        int minLenght = Math.Min(firstString.Length, secondString.Length);
        int maxLenght = Math.Max(firstString.Length, secondString.Length);
        string minString = null;
        string maxString = null;

        if (firstString.Length > secondString.Length)
        {
            maxString = firstString;
            minString = secondString;
        }
        else if (firstString.Length < secondString.Length)
        {
            maxString = secondString;
            minString = firstString;
        }
        else
        {
            minString = firstString;
            maxString = secondString;
        }

        for (int i = 0; i < minLenght; i++)
        {
            if (!words.ContainsKey(maxString[i]))
            {
                words[maxString[i]] = minString[i];
            }
            else if (words[maxString[i]] != minString[i])
            {
                result = "false";
                return result;
            }
        }

        for (int i = minLenght; i < maxLenght; i++)
        {
            if (!words.ContainsKey(maxString[i]))
            {
                result = "false";
                break;
            }
        }

        return result;
    }
}