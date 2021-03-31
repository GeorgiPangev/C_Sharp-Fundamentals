using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamWorckProjeect
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Teams> teams = new List<Teams>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("-")
                    .ToArray();

                Teams newTeam = new Teams(input[0], input[1]);

                bool isTeamExist = teams.Select(x => x.TeamName)
                    .Contains(newTeam.TeamName);
                bool isCreatorExixt = teams.Select(x => x.Creator)
                    .Contains(newTeam.Creator);

                if (!isTeamExist&&!isCreatorExixt)
                {
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {newTeam.TeamName} " +
                        $"has been created by {newTeam.Creator}!");
                }
                else if (isTeamExist)
                {
                    Console.WriteLine($"Team {newTeam.TeamName} was already created!");
                }
                else if (isCreatorExixt)
                {
                    Console.WriteLine($"{newTeam.Creator} cannot create another team!");
                }
            }
            
            string inputII = Console.ReadLine();
            
            while (inputII!= "end of assignment")
            {
                string[] newMembers = inputII
                .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                string name = newMembers[0];
                string party = newMembers[1];

                bool isTeamExist = teams.Select(x => x.TeamName)
                    .Contains(newMembers[1]);

                bool isMemberIn = teams.Select(x => x.Membars)
                   .Any(x => x.Contains(name));

                bool isCreatotIsMember = teams.Select(x => x.Creator)
                    .Contains(name);
                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {newMembers[1]} does not exist!");
                }
                else if (isMemberIn||isCreatotIsMember)
               // else if (isCreatotIsMember)
                {
                    Console.WriteLine($"Member {newMembers[0]} cannot join team {newMembers[1]}!");
                }
                else if (isTeamExist && !isMemberIn && !isCreatotIsMember)
               // else if (isTeamExist && !isCreatotIsMember)
                {
                    int index = teams.FindIndex(x => x.TeamName == newMembers[1]);
                    teams[index].Membars.Add(newMembers[0]);
                }

                inputII = Console.ReadLine();
                //newMembers = Console.ReadLine()
                //.Split("->", StringSplitOptions.RemoveEmptyEntries)
                //.ToArray();
            }
            Teams[] fulTeams = teams.OrderByDescending(x=>x.Membars.Count)
                .ThenBy(c=>c.TeamName)
                .Where(x => x.Membars.Count > 0)
                .ToArray();

            Teams[] emptiTeams = teams.OrderBy(x => x.TeamName)
                .Where(c => c.Membars.Count <= 0)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (Teams team in fulTeams)
            {
                sb.AppendLine(team.TeamName);
                sb.AppendLine($"- {team.Creator}");
                foreach (var memb in team.Membars.OrderBy(x=>x))
                {
                    sb.AppendLine($"-- {memb}");
                }
            }
            sb.AppendLine("Teams to disband:");
            for (int i = 0; i < emptiTeams.Length; i++)
            {
                sb.AppendLine(emptiTeams[i].TeamName); 
            }

            Console.WriteLine(sb);
        }
    }
    class Teams
    {
        public Teams(string creator, string teamName)  
        {
            TeamName = teamName;
            Creator = creator;
            Membars = new List<string>();
        }
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Membars { get; set; }



    }
}
