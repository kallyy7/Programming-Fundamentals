using System;

public class BPMCounter
{
    public static void Main()
    {
        decimal beatsPerMinute = decimal.Parse(Console.ReadLine());
        decimal numberOfbeats = decimal.Parse(Console.ReadLine());
        decimal time = (numberOfbeats / beatsPerMinute) * 60;

        Console.WriteLine($"{Math.Round(numberOfbeats / 4, 1)} bars - {Math.Floor(time / 60)}m {Math.Truncate(time % 60)}s");
    }
}
