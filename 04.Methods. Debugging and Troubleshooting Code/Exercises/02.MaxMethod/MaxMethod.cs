using System;

public class MaxMethod
{
    public static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        GetMax(num1, num2, num3);
    }
    private static void GetMax(int num1, int num2, int num3)
    {
        Console.WriteLine(Math.Max(Math.Max(num1, num2), num3));
    }
}