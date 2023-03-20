using System.Text.RegularExpressions;

string text = Console.ReadLine();
string pattern = @"(\=|\/)(?<place>[A-Z][A-Za-z]{2,})\1";
MatchCollection places = Regex.Matches(text, pattern);
int sum = 0;
List<string> placesList = new List<string>();

foreach (Match place in places)
{
    sum += place.Groups["place"].Value.Length;
    placesList.Add(place.Groups["place"].Value);
}

Console.WriteLine($"Destinations: {string.Join(", ", placesList)}");
Console.WriteLine($"Travel Points: {sum}");
