using System;

public class ChooseADrink
{
    public static void Main()
    {
        string profession = Console.ReadLine().ToLower();

        switch (profession)
        {
            case "athlete":
                Console.WriteLine("Water");
                break;
            case "businessman":
            case "businesswoman":
                Console.WriteLine("Coffee");
                break;
            case "softuni student":
                Console.WriteLine("Beer");
                break;
            default:
                Console.WriteLine("Tea");
                break;
        }
    }
}