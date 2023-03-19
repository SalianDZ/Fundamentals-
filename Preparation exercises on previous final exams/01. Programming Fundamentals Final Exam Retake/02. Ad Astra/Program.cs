using System.Reflection.Metadata;
using System.Text.RegularExpressions;

string pattern = @"(\#|\|)(?<itemName>(([a-zA-Z]+)(\s)?([A-Za-z]+)?))(\1)(?<date>\d{2}\/\d{2}\/\d{2})(\1)(?<calories>\d+)(\1)";
string text = Console.ReadLine();
int sum = 0;

Regex Regex = new Regex(pattern);
MatchCollection matchCollection = Regex.Matches(text);
Dictionary<string, FruitsInfo> foods = new Dictionary<string, FruitsInfo>();

foreach (Match match in matchCollection)
{
    if (match.Success)
    {
        string currentDate = match.Groups["date"].Value;
        int currentCalories = int.Parse(match.Groups["calories"].Value);
        sum += currentCalories;
        foods[match.Groups["itemName"].Value] = new FruitsInfo(currentDate, currentCalories);
    }
}


Console.WriteLine($"You have food to last you for: {(int) (sum / (2000 * 1.0))} days!");
foreach (var food in foods)
{
    Console.WriteLine($"Item: {food.Key}, Best before: {food.Value.ExpirationDate}, Nutrition: {food.Value.Calories}");
}



public class FruitsInfo 
{
    public FruitsInfo(string expirationDate, int calories)
    {
        ExpirationDate = expirationDate;
        Calories = calories;
    }

    public string ExpirationDate { get; set; }

    public int Calories { get; set; }
}