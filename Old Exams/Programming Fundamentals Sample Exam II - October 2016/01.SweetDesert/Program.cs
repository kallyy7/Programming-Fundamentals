using System;

namespace _01.SweetDesert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriestPrice = decimal.Parse(Console.ReadLine());

            decimal portions = Math.Ceiling(numberOfGuests / 6.0m);
            decimal totalPrice = (portions * (2 * bananasPrice)) + (portions * (4 * eggsPrice)) + (portions * (0.2m * berriestPrice));

            if (amountOfCash > totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalPrice - amountOfCash):f2}lv more.");
            }
        }
    }
}
