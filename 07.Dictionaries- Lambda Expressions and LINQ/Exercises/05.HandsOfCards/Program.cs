using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> cardsByPlayer = new Dictionary<string, HashSet<string>>();
            Dictionary<string, int> players = new Dictionary<string, int>();
            Dictionary<string, int> type = new Dictionary<string, int>()
            {
                { "S", 4 }, { "H", 3 }, { "D", 2 }, { "C", 1 }
            };
            Dictionary<string, int> cardsPower = new Dictionary<string, int>()
            {
                { "1", 1 }, { "2", 2 }, { "3", 3 }, { "4", 4 },
                { "5", 5 }, { "6", 6 }, { "7", 7 }, { "8", 8 },
                { "9", 9 }, { "10", 10 }, { "J", 11 }, { "Q", 12 },
                { "K", 13 }, { "A", 14 }
            };

            List<string> input = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToList();
           

            while (!input[0].Equals("JOKER"))
            {
                string player = input[0];
                List<string> cards = input[1].Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < cards.Count; i++)
                {
                    int result = 0;
                    
                    if (cards[i][1].Equals('S') || cards[i][1].Equals('H') || cards[i][1].Equals('D') || cards[i][1].Equals('C'))
                    {
                        string first = cards[i][0].ToString();
                        int firstt = cardsPower[first];
                        string second = cards[i][1].ToString();
                        int secondd = type[second];
                        result += firstt * secondd;
                    }
                    else
                    {
                        string first = cards[i][0].ToString();
                        first += cards[i][1].ToString();
                        int firstt = cardsPower[first];
                        string second = cards[i][2].ToString();
                        int secondd = type[second];
                        result += firstt * secondd;
                    }

                    if (players.ContainsKey(player))
                    {
                        if (!cardsByPlayer[player].Contains(cards[i]))
                        {
                            players[player] += result;
                            HashSet<string> cardsByCurrentPlayer = cardsByPlayer[player];
                            cardsByCurrentPlayer.Add(cards[i]);
                        }

                    }
                    else
                    {
                        players[player] = result;
                        cardsByPlayer[player] = new HashSet<string>();
                        HashSet<string> cardsByCurrentPlayer = cardsByPlayer[player];
                        cardsByCurrentPlayer.Add(cards[i]);
                    }
                }

                input = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToList();              
            }

            foreach (var player in players)
            {
                Console.WriteLine("{0}: {1}", player.Key, player.Value);
            }
        }
    }
}
