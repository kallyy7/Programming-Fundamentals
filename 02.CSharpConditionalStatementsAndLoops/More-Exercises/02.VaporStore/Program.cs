using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double totalPrice = 0;

            while (game != "Game Time")
            {
                

                if (game == "OutFall 4")
                {
                    if (money < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        money -= 39.99;
                        totalPrice += 39.99;
                        Console.WriteLine("Bought OutFall 4");
                    }
                }
                else if (game == "CS: OG")
                {
                    if (money < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        money -= 15.99;
                        totalPrice += 15.99;
                        Console.WriteLine("Bought CS: OG");
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (money < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        money -= 19.99;
                        totalPrice += 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                }
                else if (game == "Honored 2")
                {
                    if (money < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        money -= 59.99;
                        totalPrice += 59.99;
                        Console.WriteLine("Bought Honored 2");
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (money < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        money -= 29.99;
                        totalPrice += 29.99;
                        Console.WriteLine("Bought RoverWatch");
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (money < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        money -= 39.99;
                        totalPrice += 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
               
                game = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalPrice:f2}. Remaining: ${money:f2}");
        }
    }
}
