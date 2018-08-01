using System;

public class PrintingTriangle
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintTriangle(n);
    }
    private static void PrintTriangle(int n)
    {
        PrintTopPart(n);
        PrintBottomPart(n);
    }
    private static void PrintTopPart(int n)
    {
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }

            Console.WriteLine();
        }
    }
    private static void PrintBottomPart(int n)
    {
        for (int row = n - 1; row >= 1; row--)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }

            Console.WriteLine();
        }
    }
}