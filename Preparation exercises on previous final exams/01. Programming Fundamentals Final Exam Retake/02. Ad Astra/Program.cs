using System.Text.RegularExpressions;

string pattern = @"(\#|\|)(?<foodName>[A-Za-z\s]+)\1(?<expirationDate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";
string text = Console.ReadLine();
int caloriesSum = 0;
MatchCollection foods = Regex.Matches(text, pattern);

foreach (Match food in foods)
{
    int currentCalories = int.Parse(food.Groups["calories"].Value);
    caloriesSum += currentCalories;
}

Console.WriteLine($"You have food to last you for: {caloriesSum / 2000} days!");

foreach (Match food in foods)
{
    Console.WriteLine($"Item: {food.Groups["foodName"].Value}, Best before: {food.Groups["expirationDate"].Value}, Nutrition: {food.Groups["calories"].Value}");
}