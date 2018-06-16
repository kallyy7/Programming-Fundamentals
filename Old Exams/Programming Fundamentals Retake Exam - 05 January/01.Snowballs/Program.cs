using System;
using System.Numerics;

namespace _01.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 0;

            int[] data = new int[3];

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int value = snowballSnow / snowballTime;
                BigInteger current =(BigInteger) Math.Pow(value, snowballQuality);

                if (current >= result)
                {
                    result = current;
                    data[0] = snowballSnow;
                    data[1] = snowballTime;
                    data[2] = snowballQuality;
                }

            }

            Console.WriteLine($"{data[0]} : {data[1]} = {result} ({data[2]})");
        }
    }
}
