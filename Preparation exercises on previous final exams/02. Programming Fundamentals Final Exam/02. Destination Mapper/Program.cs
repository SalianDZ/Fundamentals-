using System.Text.RegularExpressions;

string pattern = @"(\=|\/)(?<name>[A-Z][A-Za-z]{2,})\1";
string text = Console.ReadLine();
List<string> destinationsList = new List<string>();

MatchCollection destinations = Regex.Matches(text, pattern);
int sum = 0;

foreach (Match match in destinations)
{
    sum += match.Groups["name"].Length;
    destinationsList.Add(match.Groups["name"].Value);
}

Console.WriteLine($"Destinations: {string.Join(", ", destinationsList)}");
Console.WriteLine($"Travel Points: {sum}");