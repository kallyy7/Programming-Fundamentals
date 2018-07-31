using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrainingHallEquip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = int.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            string itemName = null;
            double itemPrice = 0;
            int itemCount = 0;
            double totalPrice = 0;

            for (int i = 1; i <= numberOfItems; i++)
            {
                itemName = Console.ReadLine();
                itemPrice = double.Parse(Console.ReadLine());
                itemCount = int.Parse(Console.ReadLine());
                totalPrice += itemPrice * itemCount;
                if (itemCount > 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
            }
            Console.WriteLine($"Subtotal: ${totalPrice:f2}");
            if (totalPrice < budget)
            {
                Console.WriteLine($"Money left: ${budget - totalPrice:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${totalPrice - budget:f2} more.");
            }
        
        }
    }
}
