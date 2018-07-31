using System;

public class Restaurant
{
    public static void Main()
    {
        int groupSize = int.Parse(Console.ReadLine());
        string package = Console.ReadLine();

        double price = 0;
        string hall = null;

        if (groupSize <= 50)
        {
            hall = "Small Hall";
            price = 2500;
        }
        else if (groupSize <= 100)
        {
            hall = "Terrace";
            price = 5000;
        }
        else if (groupSize <= 120)
        {
            hall = "Great Hall";
            price = 7500;
        }
        else
        {
            Console.WriteLine("We do not have an appropriate hall.");
            return;
        }

        if (package == "Normal")
        {
            price += 500;
            price *= 0.95;
        }
        else if (package == "Gold")
        {
            price += 750;
            price *= 0.90;
        }
        else if (package == "Platinum")
        {
            price += 1000;
            price *= 0.85;
        }

        Console.WriteLine($"We can offer you the {hall}");
        Console.WriteLine($"The price per person is {price / groupSize:f2}$");
    }
}