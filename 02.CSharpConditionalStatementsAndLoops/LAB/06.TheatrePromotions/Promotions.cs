using System;

public class Promotions
{
    public static void Main()
    {
        string typeOfDay = Console.ReadLine().ToLower();
        int age = int.Parse(Console.ReadLine());

        int price = 0;

        if (age < 0)
        {
            Console.WriteLine("Error!");
            return;
        }

        if (typeOfDay == "weekday")
        {
            if (age <= 18 || (age > 64 && age <= 122))
            {
                price = 12;
            }
            else if (age <= 64)
            {
                price = 18;
            }
        }
        else if (typeOfDay == "weekend")
        {
            if (age <= 18 || (age > 64 && age <= 122))
            {
                price = 15;
            }
            else if (age <= 64)
            {
                price = 20;
            }
        }
        else if (typeOfDay == "holiday")
        {
            if (age <= 18)
            {
                price = 5;
            }
            else if (age <= 64)
            {
                price = 12;
            }
            else if (age <= 122)
            {
                price = 10;
            }
        }

        Console.WriteLine($"{price}$");
    }
}