using System;
using System.Collections.Generic;

public class PrimesGivenRa
{
    public static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        FindPrimesInRange(startNum, endNum);
    }
    private static void FindPrimesInRange(int startNum, int endNum)
    {
        if (startNum > endNum)
        {
            Console.WriteLine("(empty list)");
        }
        else
        {
            List<long> integers = new List<long>();

            for (long i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;

                if(i == 0 || i == 1)
                {
                    isPrime = false;
                }

                for (long numberToDivideBy = 2; numberToDivideBy <= Math.Sqrt(i); numberToDivideBy++)
                {
                    if (i % numberToDivideBy == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    integers.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", integers));
        }
    }
}