using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PriceChangeAlert
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double border = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                double nextPrice = double.Parse(Console.ReadLine());
                double difference = Proc(price, nextPrice);
                bool isSignificantDifference = IsEnoughDiff(difference, border);
                string message = Get(nextPrice, price, difference, isSignificantDifference);
                Console.WriteLine(message);
                price = nextPrice;
            }
        }
        private static string Get(double nextPrice, double price, double difference, bool TrueOrFalse)
        {
            string to = "";
            if (difference == 0)
            {
                to = string.Format("NO CHANGE: {0}", nextPrice);
                return to;
            }
            else if (!TrueOrFalse)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
                return to;
            }
            else if (TrueOrFalse && (difference > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
                return to;
            }
            else if (TrueOrFalse && (difference < 0))
            {
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
                return to;
            }
            return to;
        }
        private static bool IsEnoughDiff(double threshold, double isDiff)
        {
            if (Math.Abs(threshold) >= isDiff)
            {
                return true;
            }
            return false;
        }
        private static double Proc(double price, double nextPrice)
        {
            double difference = (nextPrice - price) / price;
            return difference;
        }
    }
}
