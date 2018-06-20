using System;

namespace _01.TheaThePhoto
{
    class Program
    {
        static void Main(string[] args)
        {
            long amountOfPics = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filteredPics = (long)Math.Ceiling((amountOfPics * filterFactor) / 100.0);
            long filteredPicsTime = filteredPics * uploadTime;
            long totalPicsTime = amountOfPics * filterTime;
            long totalSeconds = totalPicsTime + filteredPicsTime;

            TimeSpan result = TimeSpan.FromSeconds(totalSeconds);

            Console.WriteLine($"{result.Days:0}:{result.Hours:00}:{result.Minutes:00}:{result.Seconds:00}");
        }
    }
}
