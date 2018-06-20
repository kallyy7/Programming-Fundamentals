using System;

namespace _01.SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Parse(Console.ReadLine());
            long numberOfSteps = long.Parse(Console.ReadLine());
            long timeInSeconds = long.Parse(Console.ReadLine());
            long totalSeconds = numberOfSteps * timeInSeconds;

            DateTime timeArrival = time.AddSeconds(totalSeconds);

            Console.WriteLine($"Time Arrival: {timeArrival:HH:mm:ss}");
        }
    }
}
