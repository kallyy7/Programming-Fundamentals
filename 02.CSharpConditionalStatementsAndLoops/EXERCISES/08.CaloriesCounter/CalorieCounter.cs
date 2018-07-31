using System;

public class CalorieCounter
{
    public static void Main()
    {
        int products = int.Parse(Console.ReadLine());

        string ingredients = null;
        double calories = 0;

        for (int i = 0; i < products; i++)
        {
            ingredients = Console.ReadLine().ToLower();

            if (ingredients == "cheese")
            {
                calories += 500;
            }
            else if (ingredients == "tomato sauce")
            {
                calories += 150;
            }
            else if (ingredients == "salami")
            {
                calories += 600;
            }
            else if (ingredients == "pepper")
            {
                calories += 50;
            }
        }

        Console.WriteLine($"Total calories: {calories}");
    }
}