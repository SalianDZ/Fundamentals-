using System.Data;
using System.Security;

Dictionary<string, CitiesInfo> cities = new Dictionary<string, CitiesInfo>();

while (true)
{
    string[] currentCity = Console.ReadLine()
        .Split("||", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (currentCity[0] == "Sail")
    {
        break;
    }

    string currentCityName = currentCity[0];
    int population = int.Parse(currentCity[1]);
    int gold = int.Parse(currentCity[2]);
    if (!cities.ContainsKey(currentCityName))
    {
        cities[currentCityName] = new CitiesInfo(population, gold);
        continue;
    }

    cities[currentCityName].Population += population;
    cities[currentCityName].Gold += gold;
}

while (true)
{
    string[] command = Console.ReadLine()
        .Split("=>", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (command[0] == "End")
    {
        break;
    }
    else if (command[0] == "Plunder")
    {
        string town = command[1];
        int people = int.Parse(command[2]); 
        int gold = int.Parse(command[3]);

        if (cities.ContainsKey(town))
        {
            cities[town].Population -= people;
            cities[town].Gold -= gold;
            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
        }

        if (cities[town].Gold <= 0 || cities[town].Population <= 0)
        {
            Console.WriteLine($"{town} has been wiped off the map!");
            cities.Remove(town);
        }
    }
    else if (command[0] == "Prosper")
    {
        string town = command[1];
        int gold = int.Parse(command[2]);

        if (gold < 0)
        {
            Console.WriteLine("Gold added cannot be a negative number!");
            continue;
        }

        cities[town].Gold += gold;
        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
    }
}

if (cities.Count > 0)
{
    Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
    foreach (var city in cities)
    {
        Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
    }
}
else
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}


class CitiesInfo
{
    public CitiesInfo(int population, int gold)
    {
        Population = population;
        Gold = gold;
    }

    public int Population { get; set; }

    public int Gold{ get; set; }
}