using System.Text.RegularExpressions;
using System.Xml.Schema;

List<string> furniture = new List<string>();
double totalMoneySpend = 0;

string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
Regex regex = new Regex(pattern);

string inputLine;
while ((inputLine = Console.ReadLine()) != "Purchase")
{
    Match match = regex.Match(inputLine);
    if (match.Success)
    {
        string furnitureName = match.Groups["furnitureName"].Value;
        double pricePerUnit = double.Parse(match.Groups["price"].Value);
        int quantity = int.Parse(match.Groups["quantity"].Value);

        furniture.Add(furnitureName);
        totalMoneySpend += pricePerUnit * quantity;
    }
}

Console.WriteLine($"Bought furniture:");
foreach (string furnitureName in furniture)
{
    Console.WriteLine(furnitureName);
}
Console.WriteLine($"Total money spend: {totalMoneySpend:f2}");