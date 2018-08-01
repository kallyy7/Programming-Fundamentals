using System;
using System.Linq;

public class ExtractMiddle12Or3Elements
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int evenMiddle = (numbers.Length / 2) - 1;

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