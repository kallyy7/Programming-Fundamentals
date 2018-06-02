using System;
using System.Linq;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();

            LargestCommonEnd(firstLine, secondLine);
        }
        static void LargestCommonEnd(string[] firstLine, string[] secondLine)
        {
            int min = Math.Min(firstLine.Length, secondLine.Length);
            int halfLenght = min / 2;
            int leftCount = 0;
            int rightCount = 0;

            if (firstLine.Length == 1 || secondLine.Length == 1)
            {
                if (firstLine.Contains(secondLine[0]) || secondLine.Contains(firstLine[0]))
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(0);
                }
                return;
            }

            for (int i = 0; i < halfLenght - 1; i++)
            {
                if (firstLine.Contains(secondLine[i]))
                {
                    leftCount++;
                }
            }

            for (int i = halfLenght - 1; i < min; i++)
            {
                if (firstLine.Contains(secondLine[i]))
                {
                    rightCount++;
                }
            }

            if (rightCount == 0 && leftCount == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(Math.Max(rightCount, leftCount));
            }
        }
    }

}
