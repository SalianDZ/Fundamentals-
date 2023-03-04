using System.Security;

Dictionary<string, PlantInfo> plants = new Dictionary<string, PlantInfo>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] currentPlantInfo = Console.ReadLine()
        .Split("<->", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string plantName = currentPlantInfo[0];
    int plantRarity = int.Parse(currentPlantInfo[1]);

    if (!plants.ContainsKey(plantName))
    {
        plants[plantName] = new PlantInfo(plantRarity, 0, 0);
    }
    else
    {
        plants[plantName].Rarity = plantRarity;
    }
}

while (true)
{
    string[] currentCommand = Console.ReadLine()
        .Split(": ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (currentCommand[0] == "Exhibition")
    {
        break;
    }
    else if (currentCommand[0] == "Rate")
    {
        string[] nameAndRatingCombined = currentCommand[1]
            .Split(" - ")
            .ToArray();
        string currentPlantName = nameAndRatingCombined[0];
        double currentPlantRating = double.Parse(nameAndRatingCombined[1]);

        if (plants.ContainsKey(currentPlantName))
        {
            plants[currentPlantName].Rating += currentPlantRating;
            plants[currentPlantName].RateCounter++;
            continue;
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    else if (currentCommand[0] == "Update")
    {
        string[] nameAndRarityCombined = currentCommand[1]
            .Split(" - ")
            .ToArray();

        string currentPlantName = nameAndRarityCombined[0];
        int currentPlantRarity = int.Parse(nameAndRarityCombined[1]);

        if (plants.ContainsKey(currentPlantName))
        {
            plants[currentPlantName].Rarity = currentPlantRarity;
            continue;
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    else if (currentCommand[0] == "Reset")
    {
        string currentPlantName = currentCommand[1];

        if (plants.ContainsKey(currentPlantName))
        {
            plants[currentPlantName].Rating = 0;
            plants[currentPlantName].RateCounter = 0;
            continue;
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}

Console.WriteLine("Plants for the exhibition:");
foreach (var plant in plants)
{
    if (plant.Value.Rating == 0)
    {
        Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.Rating:f2}");
    }
    else
    {
        Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.Rating / plant.Value.RateCounter:f2}");
    }
}


public class PlantInfo
{
    public PlantInfo(int rarity, double rating, int rateCounter)
    {
        Rarity = rarity;
        Rating = rating;
        RateCounter = rateCounter;
    }

    public int Rarity { get; set; }

    public double Rating { get; set; }

    public int RateCounter { get; set; }
}