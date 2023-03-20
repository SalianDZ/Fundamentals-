using System;
using System.Text.RegularExpressions;

string text = Console.ReadLine();
string pattern = @"(\#|\@)(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";
MatchCollection words = Regex.Matches(text, pattern);
List<string> wordsList = new List<string>();
bool hasMirrorWords = false;
bool temp = false;

if (words.Count > 0)
{
    Console.WriteLine($"{words.Count} word pairs found!");

    foreach (Match word in words)
    {
        string firstWord = word.Groups["firstWord"].Value.ToString();
        char[] firstWordAsCharArr = firstWord.ToCharArray();
        Array.Reverse(firstWordAsCharArr);
        string reversedFirstWord = new string(firstWordAsCharArr);
        string secondWord = word.Groups["secondWord"].Value.ToString();
        if (reversedFirstWord == secondWord)
        {
            wordsList.Add($"{firstWord} <=> {secondWord}");
            hasMirrorWords = true;
        }
    }
}
else
{
    Console.WriteLine("No word pairs found!");
    Console.WriteLine("No mirror words!");
    temp = true;
}

if (hasMirrorWords)
{
    Console.WriteLine("The mirror words are:");
    Console.WriteLine(String.Join(", ", wordsList));
}
else if (hasMirrorWords == false && temp == false)
{
    Console.WriteLine("No mirror words!");
}
