using System;
using System.Linq;

public class EqualSums
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        GetEqualSums(numbers);
    }
    private static void GetEqualSums(int[] numbers)
    {
        int leftSum = 0;
        int rightSum = 0;
        bool isEqual = false;

        if (numbers.Length == 1)
        {
            Console.WriteLine(0);
            return;
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int leftCnt = 0; leftCnt < i; leftCnt++)
            {
                leftSum += numbers[leftCnt];
            }

            for (int rightCnt = i + 1; rightCnt < numbers.Length; rightCnt++)
            {
                rightSum += numbers[rightCnt];
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                isEqual = true;
            }
            else
            {
                leftSum = rightSum = 0;
            }
        }

        if (!isEqual)
        {
            Console.WriteLine("no");
        }
    }
}