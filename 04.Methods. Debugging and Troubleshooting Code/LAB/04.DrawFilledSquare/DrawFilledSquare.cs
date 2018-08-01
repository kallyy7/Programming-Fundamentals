using System;

public class DrawFilledSquare
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        TopRows(n);
        MiddleRow(n);
        BottomRows(n);
    }
    private static void TopRows(int n)
    {
        Console.WriteLine($@"{new string('-', n * 2)}");
    }
    private static void MiddleRow(int n)
    {
        string V = "\\/";

        for (int a = 1; a < n - 1; a++)
        {
            V += "\\/";
        }

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine($"-{V}-");
        }
    }
    private static void BottomRows(int n)
    {
        Console.WriteLine($@"{new string('-', n * 2)}");
    }
}