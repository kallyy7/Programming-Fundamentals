using System;
using System.Text;

namespace _07.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');
            int secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber == 0 || firstNumber == null)
            {
                Environment.Exit(0);
            }

            int res = 0;
            int numberInMind = 0;
            int remainder = 0;

            StringBuilder result = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                res = (int.Parse(firstNumber[i].ToString()) * secondNumber + numberInMind);
                numberInMind = (res / 10);
                remainder = (res % 10);
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
}
