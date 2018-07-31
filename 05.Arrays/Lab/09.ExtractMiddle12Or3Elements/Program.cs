using System;
using System.Linq;

namespace _09.ExtractMiddle12Or3Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int evenMiddle = (numbers.Length / 2) - 1;
            int evenMiddleEnd = (numbers.Length / 2) + 1;

            if (numbers.Length == 1)
            {
                Console.WriteLine($"{{ {numbers[0]} }}");
            }
            else if (numbers.Length % 2 == 0)
            {

                Console.WriteLine($"{{ {numbers[evenMiddle]}, {numbers[evenMiddle + 1]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {numbers[evenMiddle]}, {numbers[evenMiddle + 1]}, {numbers[evenMiddle + 2]} }}");
            }

        }
    }
}
