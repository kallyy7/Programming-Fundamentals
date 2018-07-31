using System;

public class Cake
{
    public static void Main()
    {
        string ingredients = Console.ReadLine();
        int count = 0;

        while (ingredients != "Bake!")
        {
            count += 1;
            Console.WriteLine($"Adding ingredient {ingredients}.");
            ingredients = Console.ReadLine();
        }

        Console.WriteLine($"Preparing cake with {count} ingredients.");
    }
}