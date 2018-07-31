using System;

public class SumOfOddNumbers
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        int n = 1;
        int sum = 0;

        for (int i = 0; i < inputNumber; i++)
        {
            Console.WriteLine(n);
            sum += n;
            n += 2;
        }

        Console.WriteLine($"Sum: {sum}");
    }
}
