using System;

public class NeighbourWars
{
    public static void Main()
    {
        int peshoDamage = int.Parse(Console.ReadLine());
        int goshoDamage = int.Parse(Console.ReadLine());

        int peshoHealth = 100;
        int goshoHealth = 100;
        int counter = 0;

        while (true)
        {
            counter += 1;

            if (counter % 2 == 0 && counter != 1)
            {
                peshoHealth -= goshoDamage;

                if (peshoHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {counter}th round.");
                    return;
                }
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
            }
            else
            {
                goshoHealth -= peshoDamage;

                if (goshoHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {counter}th round.");
                    return;
                }
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
            }

            if (counter % 3 == 0)
            {
                peshoHealth += 10;
                goshoHealth += 10;
            }
        }
    }
}