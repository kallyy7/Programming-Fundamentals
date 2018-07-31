using System;

class MultTableSecond
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        if (secondNum > 10)
        {
            Console.WriteLine($"{inputNumber} X {secondNum} = {inputNumber * secondNum}");
        }

        for (int i = secondNum; i <= 10; i++)
        {
            Console.WriteLine($"{inputNumber} X {i} = {inputNumber * i}");
        }
    }
}