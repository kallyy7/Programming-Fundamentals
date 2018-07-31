using System;

public class ChooseADrinkSecond
{
    public static void Main()
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        double price = 0;
        double total = 0;

        switch (profession)
        {
            case "Athlete":
                price = 0.70;
                break;
            case "Businessman":
            case "Businesswoman":
                price = 1.00;
                break;
            case "SoftUni Student":
                price = 1.70;
                break;
            default:
                price = 1.20;
                break;
        }
        total = price * quantity;

        Console.WriteLine($"The {profession} has to pay {total:f2}.");
    }
}