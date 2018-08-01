using System;

public class DayOfWeek
{
    public static void Main()
    {
        string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
        int day = int.Parse(Console.ReadLine());

        if (day < 1 || day > 7)
        {
            Console.WriteLine("Invalid Day!");
            return;
        }

        Console.WriteLine(daysOfWeek[day - 1]);
    }
}