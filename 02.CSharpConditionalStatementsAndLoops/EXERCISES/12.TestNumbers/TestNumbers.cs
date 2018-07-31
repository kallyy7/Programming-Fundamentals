using System;

public class TestNumbers
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int maxSumBoundary = int.Parse(Console.ReadLine());

        int sum = 0;
        int counter = 0;

        for (int i = N; i >= 1; i--)
        {
            for (int y = 1; y <= M; y++)
            {
                sum += 3 * (i * y);
                counter += 1;

                if (sum >= maxSumBoundary)
                {
                    Console.WriteLine($"{counter} combinations");
                    Console.WriteLine($"Sum: {sum} >= {maxSumBoundary}");
                    return;
                }
            }
        }

        Console.WriteLine($"{counter} combinations");
        Console.WriteLine($"Sum: {sum}");
    }
}