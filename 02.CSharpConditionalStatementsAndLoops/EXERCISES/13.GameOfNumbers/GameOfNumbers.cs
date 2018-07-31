using System;

public class GameOfNumbers
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int magicalNumber = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int i = N; i <= M; i++)
        {
            for (int y = N; y <= M; y++)
            {
                counter += 1;

                if ((i + y) == magicalNumber)
                {
                    Console.WriteLine($"Number found! {y} + {i} = {magicalNumber}");
                    return;
                }
            }
        }

        Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
    }
}