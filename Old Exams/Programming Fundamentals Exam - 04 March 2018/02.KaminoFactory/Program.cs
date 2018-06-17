using System;
using System.Linq;

namespace _02.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNALenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int currSeq = 0;
            int maxSeq = 0;

            string[] result = null;

            int bestSeq = 0;
            int count = 0;

            while (!input.Equals("Clone them!"))
            {
                string[] newDNA = input.Split("!!!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                count++;

                for (int i = 0; i < DNALenght; i++)
                {
                    if (newDNA[i].Equals("1"))
                    {
                        currSeq++;
                    }

                }

                if (currSeq > maxSeq)
                {
                    maxSeq = currSeq;
                    result = newDNA.ToArray();
                    bestSeq = count;
                }
                else 
                {
                    if (newDNA[0].Equals("0"))
                    {
                        result = newDNA.ToArray();
                        bestSeq = count;
                    }

                }

                input = Console.ReadLine();
                currSeq = 0;

            }

            int bestSum = 0;

            for (int i = 0; i < result.Length; i++)
            {
                bestSum += int.Parse(result[i]);
            }

            Console.WriteLine($"Best DNA sample {bestSeq} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
