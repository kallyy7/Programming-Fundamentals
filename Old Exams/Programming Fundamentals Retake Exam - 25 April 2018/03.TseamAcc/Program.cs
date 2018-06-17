using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TseamAcc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split().ToList();
            List<string> commands = Console.ReadLine().Split().ToList();


            while (!commands.Contains("Play!"))
            {
                string command = commands[0];
                string game = commands[1];

                if (command.Equals("Install"))
                {
                    if (!games.Contains(game))
                    {
                        games.Add(game);
                    }
                }
                else if (command.Equals("Uninstall"))
                {
                    games.Remove(game);
                }
                else if (command.Equals("Update"))
                {
                    if (games.Contains(game))
                    {
                        games.Remove(game);
                        games.Add(game);
                    }
                }
                else if (command.Equals("Expansion"))
                {
                    string[] newGame = game.Split("-").ToArray();

                    if (games.Contains(newGame[0]))
                    {
                        int indexOfGame = games.IndexOf(newGame[0]);
                        string nameGame = newGame[0] + ":" + newGame[1];
                        games.Insert(indexOfGame + 1, nameGame);
                    }
                }

                commands = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", games));
        }
    }
}
