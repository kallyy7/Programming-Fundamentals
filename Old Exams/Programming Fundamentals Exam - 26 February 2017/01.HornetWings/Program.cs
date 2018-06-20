using System;

namespace _01.HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingFlapsN = long.Parse(Console.ReadLine());
            double distanceM = double.Parse(Console.ReadLine());
            long enduranceP = long.Parse(Console.ReadLine());

            double metersTraveled = (wingFlapsN / 1000) * distanceM;
            double flaps = wingFlapsN / 100;
            double secondsPassed = ((wingFlapsN / enduranceP) * 5) + flaps;

            Console.WriteLine($"{metersTraveled:f2} m.");
            Console.WriteLine($"{secondsPassed} s.");

        }
    }
}
