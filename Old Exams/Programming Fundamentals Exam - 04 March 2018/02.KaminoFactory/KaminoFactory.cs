using System;
using System.Linq;

public class KaminoFactory
{
    public static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] dna = new int[length];
        int dnaLength = int.MinValue;
        int dnaIndex = int.MinValue;
        int dnaSum = int.MinValue;
        int dnaStart = -1;
        int index = 1;
        string input = null;

        while ((input = Console.ReadLine()) != "Clone them!")
        {
            int[] data = input
                .Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currentLength = int.MinValue, currentIndex = int.MinValue, currentSubLength = 0, currentSubIndex = 0;
            bool isOne = false;

            for (int i = 0; i < length; i++)
            {
                if (data[i] == 1 && isOne)
                {
                    currentSubLength++;
                }
                else if (data[i] == 1)
                {
                    isOne = true;
                    currentSubIndex = i;
                    currentSubLength = 1;
                }
                else if (data[i] == 0 && isOne)
                {
                    if (currentSubLength > currentLength)
                    {
                        currentLength = currentSubLength;
                        currentIndex = currentSubIndex;
                    }
                    isOne = false;
                    currentSubLength = 0;
                    currentSubIndex = 0;
                }
            }

            if (isOne)
            {
                if (currentSubLength > currentLength)
                {
                    currentLength = currentSubLength;
                    currentIndex = currentSubIndex;
                }
            }

            if (currentLength > dnaLength)
            {
                dnaLength = currentLength;
                dnaIndex = currentIndex;
                dnaSum = data.Sum();
                dna = data;
                dnaStart = index;
            }
            else if (currentLength == dnaLength)
            {
                if (currentIndex < dnaIndex)
                {
                    dnaLength = currentLength;
                    dnaIndex = currentIndex;
                    dnaSum = data.Sum();
                    dna = data;
                    dnaStart = index;
                }
                else if (currentIndex == dnaIndex)
                {
                    if (data.Sum() > dnaSum)
                    {
                        dnaLength = currentLength;
                        dnaIndex = currentIndex;
                        dnaSum = data.Sum();
                        dna = data;
                        dnaStart = index;
                    }
                }
            }

            index++;
        }

        Console.WriteLine($"Best DNA sample {dnaStart} with sum: {dnaSum}.");
        Console.WriteLine(string.Join(" ", dna));
    }
}