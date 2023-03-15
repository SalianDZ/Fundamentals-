using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

MatchCollection matchCollection = Regex.Matches(input, pattern);

foreach (Match match in matchCollection)
{
    var groups = match.Groups;

    Console.WriteLine($"Day: {groups["day"]}, Month: {groups["month"]}, Year: {groups["year"]}");
}