using System;

public class NumInReversed
{
    public static void Main()
    {
        string number = Console.ReadLine();
        string reversed = ReverseNum(number);

        Console.WriteLine(reversed);
    }

    private static string ReverseNum(string number)
    {
        string result = null;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            result += number[i];
        }
        return result;
    }
}