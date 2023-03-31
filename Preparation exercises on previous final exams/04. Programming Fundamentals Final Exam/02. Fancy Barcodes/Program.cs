using System.Text;
using System.Text.RegularExpressions;

string pattern = @"(\@)#+(?<name>[A-Z][A-Za-z\d]{4,}[A-Z])\1#+";
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string text = Console.ReadLine();
    Match match = Regex.Match(text, pattern);
    bool hasDigit = false;
    string number = string.Empty;

    if (match.Success)
    {
        for (int j = 0; j < text.Length; j++)
        {
            if (char.IsDigit(text[j]))
            {
                number += text[j];
                hasDigit = true;
            }
        }

        if (hasDigit)
        {
            int currentNumber = int.Parse(number);
            Console.WriteLine($"Product group: {currentNumber}");
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
}