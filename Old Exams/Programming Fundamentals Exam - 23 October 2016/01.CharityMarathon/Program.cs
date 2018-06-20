using System;

namespace _01.CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDaysLenght = int.Parse(Console.ReadLine());
            int numberOfRunners = int.Parse(Console.ReadLine());
            int numberOfLapsPerRunner = int.Parse(Console.ReadLine());
            int lengthOfTrack = int.Parse(Console.ReadLine());
            int capacityOfTrack = int.Parse(Console.ReadLine());
            decimal amountOfMoneyPerKm = decimal.Parse(Console.ReadLine());

            int runners = capacityOfTrack * marathonDaysLenght;
            runners = Math.Min(runners, numberOfRunners);
            int totalMeters = runners * numberOfLapsPerRunner * lengthOfTrack;
            int totalKm = totalMeters / 1000;
            decimal moneyRAaisedForMarathon = totalKm * amountOfMoneyPerKm;

            Console.WriteLine($"Money raised: {moneyRAaisedForMarathon:f2}");
        }
    }
}
