using System;
using System.Globalization;

namespace _01.SoftuniCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < countOrders; i++)
            {
                decimal priceCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                long capsulesCount = long.Parse(Console.ReadLine());
                decimal currentPrice = (daysInMonth * capsulesCount) * priceCapsule;
                total += currentPrice;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
