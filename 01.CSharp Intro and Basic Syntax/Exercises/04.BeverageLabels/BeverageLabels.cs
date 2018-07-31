using System;

public class BeverageLabels
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energy = int.Parse(Console.ReadLine());
        double sugarContent = double.Parse(Console.ReadLine());

        double kcal = (volume * energy) / 100.0;
        double sugar = (volume * sugarContent) / 100;

        Console.WriteLine($"{volume}ml {name}:");
        Console.WriteLine($"{kcal}kcal, {sugar}g sugars");
    }
}