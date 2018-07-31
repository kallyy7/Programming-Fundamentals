using System;
using System.Collections.Generic;
using System.Linq;

public class Snowmen
{
    public static void Main()
    {
        List<int> snowmenInput = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (snowmenInput.Count > 1)
        {
            List<int> snowmenToRemove = new List<int>();

            for (int i = 0; i < snowmenInput.Count; i++)
            {
                int attackerIndex = i;

                if (snowmenToRemove.Contains(attackerIndex))
                {
                    continue;
                }

                int targetIndex = snowmenInput[attackerIndex] % snowmenInput.Count;
                int looserIndex = -1;

                if (attackerIndex == targetIndex)
                {
                    looserIndex = attackerIndex;
                    Console.WriteLine($"{attackerIndex} performed harakiri");
                }
                else
                {
                    int difference = Math.Abs(attackerIndex - targetIndex);
                    int winnerIndex = -1;

                    if (difference % 2 == 0)
                    {
                        winnerIndex = attackerIndex;
                        looserIndex = targetIndex;
                    }
                    else
                    {
                        winnerIndex = targetIndex;
                        looserIndex = attackerIndex;
                    }

                    Console.WriteLine($"{attackerIndex} x {targetIndex} -> {winnerIndex} wins");
                }
                if (!snowmenToRemove.Contains(looserIndex))
                {
                    snowmenToRemove.Add(looserIndex);
                }

                if (snowmenInput.Count == snowmenToRemove.Count + 1)
                {
                    break;
                }
            }

            snowmenInput = ClearSnowmen(snowmenInput,
                snowmenToRemove.OrderByDescending(m => m).ToList());
        }
    }

    private static List<int> ClearSnowmen(List<int> snowmenInput, List<int> snowmenToRemove)
    {
        for (int i = 0; i < snowmenToRemove.Count; i++)
        {
            snowmenInput.RemoveAt(snowmenToRemove[i]);
        }

        return snowmenInput;
    }
}