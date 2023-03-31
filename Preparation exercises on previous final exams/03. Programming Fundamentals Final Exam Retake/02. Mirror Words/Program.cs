using System.Text.RegularExpressions;

string pattern = @"(\@|\#)(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";
string text = Console.ReadLine();

MatchCollection words = Regex.Matches(text, pattern);
List<string> mirrorWords = new List<string>();
bool hasMirrorWords = false;
if (words.Count > 0)
{
    Console.WriteLine($"{words.Count} word pairs found!");
    foreach (Match item in words)
	{
		string firstWord = item.Groups["firstWord"].Value;
		string secondWord = item.Groups["secondWord"].Value;
		char[] charArray = secondWord.ToCharArray();
		Array.Reverse(charArray);
		string secondWordReversed = new string(charArray); 
		if (firstWord == secondWordReversed)
		{
			mirrorWords.Add($"{firstWord} <=> {secondWord}");
			hasMirrorWords = true;
		}
	}
}
else
{
    Console.WriteLine("No word pairs found!");
}

if (hasMirrorWords)
{
	Console.WriteLine("The mirror words are:");
	Console.WriteLine(String.Join(", ", mirrorWords));
}
else
{
	Console.WriteLine("No mirror words!");
}
