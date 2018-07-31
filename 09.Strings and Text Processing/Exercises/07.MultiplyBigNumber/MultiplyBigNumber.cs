using System;
using System.Text;

public class MultiplyBigNumber
{
    public static void Main()
    {
        string firstNumber = Console.ReadLine().TrimStart('0');
        int secondNumber = int.Parse(Console.ReadLine());

        if (secondNumber == 0 || firstNumber == null)
        {
            Environment.Exit(0);
        }

        int numberInMind = 0;

        StringBuilder result = new StringBuilder();

        for (int i = firstNumber.Length - 1; i >= 0; i--)
        {
            int res = (int.Parse(firstNumber[i].ToString()) * secondNumber + numberInMind);
            numberInMind = (res / 10);
            int remainder = (res % 10);
            result.Append(remainder);

            if (i == 0 && numberInMind != 0)
            {
                result.Append(numberInMind);
            }
        }

        char[] resultToCharArr = result.ToString().ToCharArray();
        Array.Reverse(resultToCharArr);

        Console.WriteLine(new string(resultToCharArr));
    }
}