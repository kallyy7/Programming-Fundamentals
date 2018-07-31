using System;

public class BoatSimulator
{
    public static void Main()
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());
        int counter = int.Parse(Console.ReadLine());

        int firstCountMoves = 0;
        int secondCountMoves = 0;

        for (int i = 1; i <= counter; i++)
        {
            string current = Console.ReadLine();
            int lenght = current.Length;

            if (current == "UPGRADE")
            {
                first += (char)3;
                second += (char)3;
            }

            if (i % 2 != 0)
            {
                firstCountMoves += lenght;
            }
            else if (i % 2 == 0)
            {
                secondCountMoves += lenght;
            }

            if (secondCountMoves >= 50 || firstCountMoves >= 50)
            {
                break;
            }
        }

        if (firstCountMoves >= secondCountMoves)
        {
            Console.WriteLine(first);
        }
        else
        {
            Console.WriteLine(second);
        }
    }
}