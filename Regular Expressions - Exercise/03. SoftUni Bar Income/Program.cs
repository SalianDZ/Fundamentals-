using System.Text.RegularExpressions;

string pattern = @"^[^\%\$\.\|]*?%(?<name>[A-Z][a-z]+)%[^\%\$\.\|]*?<(?<product>\w+)>[^\%\$\.\|]*?\|(?<quantity>\d+)\|[^\%\$\.\|]*?(?<price>\d+(\.\d+)?)\$[^\%\$\.\|]*?$";
Regex regex = new Regex(pattern);
double totalIncome = 0;

while (true)
{
    string currentInput = Console.ReadLine();

	if (currentInput == "end of shift")
	{
		break;
	}

	Match match = regex.Match(currentInput);

	if (match.Success)
	{
		string userName = match.Groups["name"].Value;
		string productName = match.Groups["product"].Value;
		int quantity = int.Parse(match.Groups["quantity"].Value);
		double price = double.Parse(match.Groups["price"].Value);
		totalIncome += quantity * price;

		Console.WriteLine($"{userName}: {productName} - {quantity * price:f2}");
    }
}
Console.WriteLine($"Total income: {totalIncome:f2}");