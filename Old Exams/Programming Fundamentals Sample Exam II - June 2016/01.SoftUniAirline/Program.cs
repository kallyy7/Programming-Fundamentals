using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SoftUniAirline
{
    class Program
    {
        static void Main(string[] args)
        {
            int flightsCount = int.Parse(Console.ReadLine());
            List<decimal> result = new List<decimal>();

            for (int i = 0; i < flightsCount; i++)
            {
                decimal adultPassengersCount = decimal.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                decimal youthPassengersCount = decimal.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                decimal flightDuration = decimal.Parse(Console.ReadLine());

                decimal income = ((adultPassengersCount * adultTicketPrice) + (youthPassengersCount * youthTicketPrice));
                decimal expense = flightDuration * fuelConsumptionPerHour * fuelPricePerHour;
                decimal profit = income - expense;

                result.Add(profit);

                if (income >= expense)
                {
                    Console.WriteLine($"You are ahead with {profit:f3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:f3}$.");
                }
            }

            Console.WriteLine($"Overall profit -> {result.Sum():f3}$.");
            Console.WriteLine($"Average profit -> {result.Average():f3}$.");
        }
    }
}
