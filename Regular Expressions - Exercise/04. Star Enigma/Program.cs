using System.Text;
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());
List<string> attackedPlanets = new List<string>();
List<string> destroyedPlanets = new List<string>();

for (int i = 0; i < n; i++)
{
    string encryptedMessage = Console.ReadLine();
    string decryptedMessage = DecryptMessage(encryptedMessage);
    string pattern = @"\@(?<planetName>[A-Za-z]+)[^\@\-\,\!\:\>]*?\:\d+[^\@\-\,\!\:\>]*?\!(?<attackType>A|D)\![^\@\-\,\!\:\>]*?\-\>\d+";
    Regex regex = new Regex(pattern);
    Match match = regex.Match(decryptedMessage);
    if (match.Success)
    {
        string planetName = match.Groups["planetName"].Value;
        string attackType = match.Groups["attackType"].Value;

        if (attackType == "A")
        {
            attackedPlanets.Add(planetName);
        }
        else if (attackType == "D")
        {
            destroyedPlanets.Add(planetName);
        }
    }
}

Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
foreach (var planet in attackedPlanets.OrderBy(p => p))
{
    Console.WriteLine($"-> {planet}");
}
Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
foreach (var planet in destroyedPlanets.OrderBy(p => p))
{
    Console.WriteLine($"-> {planet}");
}


static string DecryptMessage(string encryptedMessage)
{
    int step = 0;
    StringBuilder decryptedMessage = new StringBuilder();

    foreach (char currentChar in encryptedMessage.ToLower())
    {
        if (currentChar == 's' || currentChar == 't' || currentChar == 'a' || currentChar == 'r')
        {
            step++;
        }
    }

    foreach (char currentChar in encryptedMessage)
    {
        decryptedMessage.Append((char) (currentChar - step));
    }
    return decryptedMessage.ToString();
}