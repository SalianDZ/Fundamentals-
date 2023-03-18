using System.Text.RegularExpressions;
using System.Text;

int sum = 0;
int counter = 1;
string namePattern = @"(?<name>[A-Za-z+])";
string numberPattern = @"(?<number>\d)";
List<string> names = Console.ReadLine().Split(", ").ToList();
Dictionary<string, int> people = new Dictionary<string, int>();

foreach (var name in names)
{
    people[name] = 0;
}

while (true)
{
    string currentCommand = Console.ReadLine();

    if (currentCommand == "end of race")
    {
        break;
    }

    MatchCollection nameMatches = Regex.Matches(currentCommand, namePattern);
    MatchCollection numberMatches = Regex.Matches(currentCommand, numberPattern);
    StringBuilder namesBuilder = new StringBuilder();
    StringBuilder numberBuilder = new StringBuilder();

    foreach (Match currentMatch in nameMatches)
    {
        namesBuilder.Append(currentMatch);
    }
    foreach (Match currentMatch in numberMatches)
    {
        numberBuilder.Append(currentMatch);
    }

    for (int i = 0; i < numberBuilder.Length; i++)
    {
        int currentInt = int.Parse(numberBuilder[i].ToString());
        sum += currentInt;
    }
    if (people.ContainsKey(namesBuilder.ToString()))
    {
        people[namesBuilder.ToString()] += sum;
    }
    sum = 0;
    namesBuilder.Clear();
    numberBuilder.Clear();
}

var sortedDictionary = people.OrderByDescending(x => x.Value);

foreach (var item in sortedDictionary)
{
    if (counter == 1)
    {
        Console.WriteLine($"{counter}st place: {item.Key}");
    }

    if (counter == 2)
    {
        Console.WriteLine($"{counter}nd place: {item.Key}");
    }

     if (counter == 3)
    {
        Console.WriteLine($"{counter}rd place: {item.Key}");
    }
    counter++;
    if (counter == 4)
    {
        break;
    }
}