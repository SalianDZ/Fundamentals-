using System.Text.RegularExpressions;

string pattern = @"(.+)\>(?<digits>\d{3})\|(?<lowerLetters>[a-z]{3})\|(?<upperLetters>[A-Z]{3})\|(?<symbols>[^\<\>]{3})<\1";
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string text = Console.ReadLine();
    Match currentPassword = Regex.Match(text, pattern);

    if (currentPassword.Success)
    {
        string password = string.Empty;
        password += currentPassword.Groups["digits"].Value;
        password += currentPassword.Groups["lowerLetters"].Value;
        password += currentPassword.Groups["upperLetters"].Value;
        password += currentPassword.Groups["symbols"].Value;
        Console.WriteLine($"Password: {password}");
    }
    else
    {
        Console.WriteLine("Try another password!");
    }
}