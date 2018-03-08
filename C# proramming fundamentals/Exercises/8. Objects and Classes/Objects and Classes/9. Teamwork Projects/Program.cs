using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] data = command.Split('-').ToArray();
                string name = data[0];
                string teamName = data[1];

                if(teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine("Team {0} was already created!", teamName);
                }
                else
                {
                    if(teams.Any(x => x.Creator == name))
                    {
                        Console.WriteLine("{0} cannot create another team!", name);
                    }
                    else
                    {
                        Team team = new Team();
                        team.Creator = name;
                        team.Name = teamName;
                        List<string> members = new List<string>();
                        team.Members = members;
                        teams.Add(team);
                        Console.WriteLine("Team {0} has been created by {1}!", team.Name, team.Creator);
                    }
                }
                command = Console.ReadLine();
            }


            while(command != "end of assignment")
            {
                string[] joiners = command.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string nameJoiner = joiners[0];
                string teamToJoin = joiners[1];

                if(!teams.Any(x => x.Name == teamToJoin))
                {
                    Console.WriteLine("Team {0} does not exist!", teamToJoin);
                }
                else if (teams.Any(x => x.Members.Contains(nameJoiner)) || teams.Any(x => x.Creator == nameJoiner))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", nameJoiner, teamToJoin);
                }
                else
                {
                    foreach (var squad in teams.Where(x => x.Name == teamToJoin))
                    {
                        squad.Members.Add(nameJoiner);
                    }
                }

                command = Console.ReadLine();
            }

            foreach(var squad in teams.Where(x => x.Members.Count != 0).OrderByDescending(x =>x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine("{0}", squad.Name);
                Console.WriteLine("- {0}", squad.Creator);

                foreach (var member in squad.Members.OrderBy(x => x))
                {
                    Console.WriteLine("-- {0}",member);
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var squad in teams.Where(x => x.Members.Count == 0).OrderBy(x=>x.Name))
            {
                Console.WriteLine("{0}", squad.Name);
            }
        }
    }
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members = new List<string>();
    }
}