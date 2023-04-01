using System.Text;
using System.Text.RegularExpressions;

string numberPattern = @"\d";
string text = Console.ReadLine();
long coolness = 1;

MatchCollection numbers = Regex.Matches(text, numberPattern);

foreach (Match number in numbers)
{
    coolness *= int.Parse(number.Value);
}

string pattern = @"(\:\:|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";
MatchCollection emojis = Regex.Matches(text, pattern);
List<string> coolEmojis = new List<string>();
foreach (Match emoji in emojis)
{
	int currentSum = 0;
	for (int i = 0; i < emoji.Groups["emoji"].Value.Length; i++)
	{
		currentSum += emoji.Groups["emoji"].Value[i];
	}
	if (currentSum > coolness)
	{
		coolEmojis.Add(emoji.Value);
	}
}

Console.WriteLine($"Cool threshold: {coolness}");
Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
foreach (var emoji in coolEmojis)
{
	Console.WriteLine(emoji);
}