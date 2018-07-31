using System;
using System.Linq;

namespace _04.GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long searchNumber = long.Parse(Console.ReadLine());
            int br = 0;
            long sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] == searchNumber)
                {
                    br++;
                    if(br == 2)
                    {
                        break;
                    }
                    sum += numbers[i];
                }
                else
                {
                    sum += numbers[i];
                }

            }

            if (br == 2)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
