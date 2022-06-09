using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> teamProject = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < teamsCount; i++)
            {

                string splitOption=input.Contains("-") ? " - " : " -> ";
                string[] splitCammand = input.Split(splitOption);
                if (input.Contains("-"))
                {
                    string teamCreator = splitCammand[0];
                    string teamName = splitCammand[1];

                    teamProject.Add(teamCreator, new List<string>());
                    teamProject[teamCreator].Add(teamName);
                    Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                }
                else if (input.Contains("->"))
                {
                    while (input != "end of assignment")
                    {
                        string memberName = splitCammand[0];
                        string teamName = splitCammand[1];
                        if (!teamProject[teamCreator].Contains(memberName))
                        {
                            teamProject[teamCreator].Add(memberName);
                        }
                        else
                        {
                            Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                        }

                        if (teamProject[teamCreator].Contains(teamName))
                        {
                            Console.WriteLine($"Team {teamName} was already created!");
                        }

                        if (teamProject[teamCreator].Contains(teamCreator))
                        {
                            Console.WriteLine($"{teamCreator} cannot create another team!");
                        }

                        if (!teamProject[teamName].Contains(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist!");
                        }
                        input = Console.ReadLine();
                    }

                    foreach (var teams in teamProject.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Key))
                    {
                        Console.WriteLine(teams.Key);
                        foreach (var member in teams.Value.OrderBy(x => teams.Value))
                        {
                            Console.Write($"-- {string.Join("\n-- ", teams.Value)}");
                            Console.WriteLine();
                        }
                    }
                }

            }
        }
    }
    class TeamProject
    {
        public string TeamOwner { get; set; }
        public List<string> Team { get; set; }
    }
}
