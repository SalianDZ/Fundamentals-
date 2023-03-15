using System.Text.RegularExpressions;

string text = Console.ReadLine();
string pattern = @"\+359(-| )2\1\d{3}\1\d{4}\b";

Regex Regex = new Regex(pattern);
MatchCollection matches = Regex.Matches(text, pattern);

Console.WriteLine(string.Join(", ", matches));