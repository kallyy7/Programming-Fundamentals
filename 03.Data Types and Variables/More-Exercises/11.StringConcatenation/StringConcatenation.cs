using System;

public class StringConcatenation
{
    public static void Main()
    {
        string delimeter = Console.ReadLine();
        string oddOrEven = Console.ReadLine();
        int counter = int.Parse(Console.ReadLine());

        string sum = null;

        for (int i = 0; i < counter; i++)
        {
            string current = Console.ReadLine();

            if (oddOrEven == "even" && i % 2 == 1)
            {
                sum += current + delimeter;
            }
            else if (oddOrEven == "odd" && i % 2 == 0)
            {
                sum += current + delimeter;
            }
        }

        Console.WriteLine(sum.Remove(sum.Length - 1, 1));
    }
}