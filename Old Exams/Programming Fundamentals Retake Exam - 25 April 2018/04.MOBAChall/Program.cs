using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MOBAChall
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            List<string> data = new List<string>();

            while (!input.Contains("Season end"))
            {
                if (input.Contains("vs"))
                {
                    data = input.Split().ToList();
                    string firstPlayerName = data[0];
                    string secondPlayerName = data[2];

                    if (players.ContainsKey(firstPlayerName) && players.ContainsKey(secondPlayerName))
                    {
                        // both players exist in the tier
                        
                    }

                }
                else
                {

                    data = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                    string playerName = data[0];
                    string position = data[1];
                    int skill = int.Parse(data[2]);

                    if (!players.ContainsKey(playerName))
                    {
                        players[playerName] = new Dictionary<string, int>();
                        players[playerName].Add(position, skill);
                    }
                    else
                    {
                        players[playerName][position] = skill;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in players.OrderByDescending(p => p.Value.Values.Sum()))
            {
                var totalSkill = player.Value.Select(pos => pos.Value).Sum();
                Console.Write(string.Join("",player.Key.Split()) + ": ");
                Console.WriteLine($"{totalSkill} skill");

                foreach (var pos in player.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"-{pos.Key}<::> {pos.Value}");
                }
            }
        }
    }
}
