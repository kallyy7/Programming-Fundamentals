using System;
using System.Linq;

public class Ladybugs
{
    public static void Main()
    {
        int sizeOfTheField = int.Parse(Console.ReadLine());
        long[] ladybugs = new long[sizeOfTheField];
        long[] ladybugIndexes = Console.ReadLine()
            .Split()
            .Select(long.Parse)
            .ToArray();

        foreach (var index in ladybugIndexes)
        {
            if (index >= 0 && index < ladybugs.Length)
            {
                ladybugs[index] = 1;
            }
        }

        string[] command = Console.ReadLine()
            .Split()
            .ToArray();

        while (!command[0].Equals("end"))
        {
            long bugIndex = long.Parse(command[0]);
            string direction = command[1];
            long flyDirection = long.Parse(command[2]);

            if ((bugIndex <= ladybugs.Length - 1 && bugIndex >= 0)
                && ladybugs[bugIndex] == 1)
            {
                if (direction.Equals("right"))
                {
                    ladybugs[bugIndex] = 0;
                    RightDirection(ladybugs, bugIndex, flyDirection);
                }
                else if (direction.Equals("left"))
                {
                    ladybugs[bugIndex] = 0;
                    LeftDirection(ladybugs, bugIndex, flyDirection);
                }
            }

            command = Console.ReadLine().Split().ToArray();
        }

        Console.WriteLine(string.Join(" ", ladybugs));
    }

    static void RightDirection(long[] ladybugs, long bugIndex, long flyDirection)
    {
        for (long i = 0; i < ladybugs.Length; i++)
        {
            if (bugIndex + flyDirection + i > ladybugs.Length - 1 || bugIndex + flyDirection + i < 0)
            {
                break;
            }

            if (ladybugs[bugIndex + flyDirection + i] == 0)
            {
                ladybugs[bugIndex + flyDirection + i] = 1;
                break;
            }
        }
    }
    static void LeftDirection(long[] ladybugs, long bugIndex, long flyDirection)
    {
        for (long i = 0; i < ladybugs.Length; i++)
        {
            if (bugIndex - flyDirection - i < 0 || bugIndex - flyDirection - i > ladybugs.Length - 1)
            {
                break;
            }

            if (ladybugs[bugIndex - flyDirection - i] == 0)
            {
                ladybugs[bugIndex - flyDirection - i] = 1;
                break;
            }
        }
    }
}