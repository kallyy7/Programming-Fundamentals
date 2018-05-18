using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            int br = 0;

            while (true)
            {
                br += 1;
                if (br % 2 == 0 && br != 1)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {

                        Console.WriteLine($"Gosho won in {br}th round.");
                        return;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                else
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {

                        Console.WriteLine($"Pesho won in {br}th round.");
                        return;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                if (br % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }

            }
        }
    }
}
