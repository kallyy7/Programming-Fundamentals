using System;

public class Program
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        while (inputNumber % 2 == 0)
        {
            Console.WriteLine("Please write an odd number.");
            inputNumber = int.Parse(Console.ReadLine());
        }
        string num = inputNumber.ToString();

        Console.WriteLine("The number is: {0}", num.Replace(@"-", ""));
    }
}