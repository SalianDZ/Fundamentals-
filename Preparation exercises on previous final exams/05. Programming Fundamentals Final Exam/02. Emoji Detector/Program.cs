using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

string pattern = @"(\:\:|\*\*)([A-Z][a-z]{2,})\1";
string text = Console.ReadLine();
int coolThreshold = 1;

foreach (char digit in text)
{
	if (char.IsDigit(digit))
	{
		int currentDigit = int.Parse(digit.ToString());
		coolThreshold *= currentDigit;
	}
}

MatchCollection emojis = Regex.Matches(text, pattern);
Console.WriteLine($"Cool threshold: {coolThreshold}");
Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

foreach (Match match in emojis)
{
	int currentMatchValue = 0;
    foreach (char item in match.Groups[2].Value)
    {
        currentMatchValue += item;
    }

    if (currentMatchValue >= coolThreshold)
    {
        Console.WriteLine(match.Value);
    }
}