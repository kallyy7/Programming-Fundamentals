using System;

public class ReverseAnArrayOfStrings
{
    public static void Main()
    {
        string[] n = Console.ReadLine().Split();
        string[] reversed = new string[n.Length];
        int counter = 0;

        for (int i = n.Length - 1; i >= 0; i--)
        {
            reversed[counter] += n[i];
            counter++;
        }

        Console.WriteLine(string.Join(" ", reversed));
    }
}