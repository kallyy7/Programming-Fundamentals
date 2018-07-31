using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal beatsPerMinute = decimal.Parse(Console.ReadLine());
            decimal numberOfbeats = decimal.Parse(Console.ReadLine());
            decimal time = (numberOfbeats / beatsPerMinute) * 60;

            Console.WriteLine($"{Math.Round(numberOfbeats / 4, 1)} bars - {Math.Floor(time / 60)}m {Math.Truncate(time % 60)}s");
        }
    }
}
