using System;

public class TriplesOfLatinLetters
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int y = 0; y < n; y++)
            {
                for (int z = 0; z < n; z++)
                {
                    char firstLetter = (char)('a' + i);
                    char secondLetter = (char)('a' + y);
                    char thirdLetter = (char)('a' + z);

                    Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                }
            }
        }
    }
}