using System.Text.RegularExpressions;

string pattern = @"(\@)#+(?<name>[A-Z][A-Za-z\d]{4,}[A-Z])\1#+";
int n = int.Parse(Console.ReadLine());
bool hasDigits = false;

for (int i = 0; i < n; i++)
{
    string currentText = Console.ReadLine();
    Match currentMatch = Regex.Match(currentText, pattern);

    if (currentMatch.Success)
    {
        string group = string.Empty;
        string currentMatchAsString = currentMatch.Value;

        for (int j = 0; j < currentMatch.Length; j++)
        {
            if (char.IsDigit(currentMatchAsString[j]))
            {
                hasDigits = true;
                group += currentMatchAsString[j];
            }
        }

        if (hasDigits)
        {
            Console.WriteLine($"Product group: {group}");
        }
        else
        {
            Console.WriteLine("Product group: 00");
        }
    }
    else
    {
        Console.WriteLine("Invalid barcode");
    }
    hasDigits = false;
}