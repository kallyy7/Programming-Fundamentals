using System;

public class CountIntegers
{
    public static void Main()
    {
        int n = 0;
        int counter = 0;

        try
        {
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                counter += 1;
            }
        }
        catch
        {
            Console.WriteLine(counter);
        }
    }
}