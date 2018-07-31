using System;

public class MultiplicationTable
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} X {i} = {n * i}");
        }
    }
}
