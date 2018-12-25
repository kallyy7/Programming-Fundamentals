﻿using System;
using System.Collections.Generic;
using System.Linq;

public class TeamworkProjects
{
    public static void Main()
    {
        int teamCount = int.Parse(Console.ReadLine());

        var teams = new List<Team>();
        var messages = new List<string>();

        for (int i = 0; i < teamCount; i++)
        {
            var teamArgs = Console.ReadLine().Split('-');
            string creator = teamArgs[0];
            string teamName = teamArgs[1];

            if (teams.Any(x => x.Name == teamName))
            {
                messages.Add($"Team {teamName} was already created!");
            }
            else if (teams.Any(x => x.Creator == creator))
            {
                messages.Add($"{creator} cannot create another team!");
            }
            else
            {
                var team = new Team(teamName, creator, new List<string>());
                messages.Add($"Team {teamName} has been created by {creator}!");
                teams.Add(team);
            }
        }

        string inputLine = Console.ReadLine();

        while (!inputLine.Equals("end of assignment"))
        {
            var teamArgs = inputLine
                .Split("- >".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string userName = teamArgs[0];
            string teamName = teamArgs[1];

            if (!teams.Any(x => x.Name == teamName))
            {
                messages.Add($"Team {teamName} does not exist!");
            }
            else
            {
                var currentTeam = teams
                    .Where(x => x.Name == teamName)
                    .First();

                if (teams.Exists(x => x.Creator == userName) || teams.Select(x => x.Members).Any(x => x.Contains(userName)))
                {
                    messages.Add($"Member {userName} cannot join team {teamName}!");
                }
                else
                {
                    currentTeam.Members.Add(userName);
                }
            }

            inputLine = Console.ReadLine();
        }

        Console.WriteLine(string.Join(Environment.NewLine, messages));

        var teamsWithMembers = teams
        .OrderByDescending(x => x.Members.Count())
        .ThenBy(x => x.Name)
        .Where(x => x.Members.Count > 0)
        .ToList();

        foreach (var team in teamsWithMembers)
        {
            Console.WriteLine(team.Name);
            Console.WriteLine($"- {team.Creator}");

            foreach (var member in team.Members.OrderBy(x => x))
            {
                Console.WriteLine($"-- {member}");
            }
        }

        var disbandTeams = teams
          .OrderBy(x => x.Name)
          .Where(x => x.Members.Count() == 0)
          .ToList();

        Console.WriteLine("Teams to disband:");
        foreach (var team in disbandTeams)
        {
            Console.WriteLine(team.Name);
        }
    }
    public class Team
    {
        public Team(string name, string creator, List<string> members)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = members;
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}