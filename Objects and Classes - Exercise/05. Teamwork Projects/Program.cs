using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

int teamsNumber = int.Parse(Console.ReadLine());
List<Team> teams = new List<Team>();
List<string> members = new List<string>();

for (int i = 0; i < teamsNumber; i++)
{
    string[] creatorAndTeamName = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string user = creatorAndTeamName[0];
    string teamName = creatorAndTeamName[1];

    if (teams.Select(x => x.TeamName).Contains(teamName))
    {
        Console.WriteLine($"Team {teamName} was already created!");
        continue;
    }
    if (teams.Select(x => x.Creator).Contains(user))
    {
        Console.WriteLine($"{user} cannot create another team!");
        continue;
    }

    Team currentTeam = new Team(user, teamName);
    teams.Add(currentTeam); 
    Console.WriteLine($"Team {teamName} has been created by {user}!");

}

while (true)
{
    string[] input = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();

    if (input[0] == "end of assignment")
    {
        break;
    }

    string teamMember = input[0];
    string teamName = input[1];

    Team team = teams.FirstOrDefault(x => x.TeamName == teamName);

    if (team == null)
    {
        Console.WriteLine($"Team {teamName} does not exist!");
        continue;
    }

    if (team.Creator == teamMember || teams.SelectMany(x => x.Members).Contains(teamMember))
    {
        Console.WriteLine($"Member {teamMember} cannot join team {teamName}!");
        continue;
    }

    team.Members.Add(teamMember);
}

List<Team> orderedTeamsByMembersCountAndName = teams
    .Where(x => x.Members.Count != 0)
    .OrderByDescending(x => x.Members.Count)
    .ThenBy(x => x.TeamName)
    .ToList();

List<Team> disbandTeams = teams.Where(x => x.Members.Count == 0).OrderBy(x => x.TeamName).ToList();
foreach (var team in orderedTeamsByMembersCountAndName)
{
    Console.WriteLine(team);
}

Console.WriteLine("Team to disband:");
foreach (var team in disbandTeams)
{
    Console.WriteLine(team.TeamName);
}


public class Team
{
    public Team(string creator, string teamName)
    {
        Creator = creator;
        TeamName = teamName;
    }

    public string Creator { get; set; }

    public string TeamName { get; set; }

    public List<string> Members { get; set; } = new List<string>();

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(TeamName);
        sb.AppendLine($"- {Creator}");

        List<string> orderedMembers = Members.OrderBy(x => x).ToList();
        foreach (var member in orderedMembers)
        {
            sb.AppendLine($"-- {member}");
        }
        return sb.ToString().TrimEnd('\n');
    }
}