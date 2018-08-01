using System;

public class FibonacciNumb
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Fibonnaci(n);
    }
    private static void Fibonnaci(int n)
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)

        {
            int temp = a + b;
            a = b;
            b = temp;
        }

        Console.WriteLine($"{b}");
    }
}