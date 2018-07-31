using System;

public class Hotel
{
    public static void Main()
    {
        string month = Console.ReadLine().ToLower();
        int nightsCount = int.Parse(Console.ReadLine());

        double studio = 0;
        double doubleRoom = 0;
        double suite = 0;

        if (month == "may" || month == "october")
        {
            studio = 50 * nightsCount;
            doubleRoom = 65 * nightsCount;
            suite = 75 * nightsCount;

            if (month == "october" && nightsCount > 7)
            {
                studio -= 50;
            }
            else if (nightsCount > 7)
            {
                studio *= 0.95;
            }
        }
        else if (month == "june" || month == "september")
        {
            studio = 60 * nightsCount;
            doubleRoom = 72 * nightsCount;
            suite = 82 * nightsCount;

            if (month == "september" && nightsCount > 7)
            {
                studio -= 60;
            }
            else if (nightsCount > 14)
            {
                doubleRoom *= 0.90;
            }

        }
        else if (month == "july" || month == "august" || month == "december")
        {
            studio = 68 * nightsCount;
            doubleRoom = 77 * nightsCount;
            suite = 89 * nightsCount;

            if (nightsCount > 14)
            {
                suite *= 0.85;
            }
        }

        Console.WriteLine($"Studio: {studio:f2} lv.");
        Console.WriteLine($"Double: {doubleRoom:f2} lv.");
        Console.WriteLine($"Suite: {suite:f2} lv.");
    }
}