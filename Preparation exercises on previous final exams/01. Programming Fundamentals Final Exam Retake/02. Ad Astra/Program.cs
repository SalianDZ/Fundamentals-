using System.Reflection.Metadata;
using System.Text.RegularExpressions;

string text = Console.ReadLine();
string pattern = @"(\||\#)(?<food>[A-Za-z\s]+)\1(?<date>(\d{2}\/)(\d{2}\/)(\d{2}))\1(?<calories>\d+)\1";
int sum = 0;

MatchCollection matchCollection = Regex.Matches(text, pattern);

foreach (Match match in matchCollection)
{
    int currentCalories = int.Parse(match.Groups["calories"].Value);
    sum += currentCalories;
}


Console.WriteLine($"You have food to last you for: {sum / 2000} days!");
foreach (Match match in matchCollection)
{
    Console.WriteLine($"Item: {match.Groups["food"]}, Best before: {match.Groups["date"]}, Nutrition: {match.Groups["calories"]}");
}