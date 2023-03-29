
Dictionary<string, PlantInformation> plants = new Dictionary<string, PlantInformation>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] currentPlant = Console.ReadLine()
        .Split("<->", StringSplitOptions.RemoveEmptyEntries);

    string plantName = currentPlant[0];
    int currentRarity = int.Parse(currentPlant[1]);

    if (!plants.ContainsKey(plantName))
    {
        plants[plantName] = new PlantInformation(currentRarity, 0, 0);
        continue;
    }

    plants[plantName].Rarity = currentRarity;
}

while (true)
{
    string[] command = Console.ReadLine()
        .Split(": ", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "Exhibition")
    {
        break;
    }
    else if (command[0] == "Rate")
    {
        string[] plantInformation = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
        string plantName = plantInformation[0];

        if (plants.ContainsKey(plantName))
        {
            int plantRating = int.Parse(plantInformation[1]);
            plants[plantName].Rating += plantRating;
            plants[plantName].RatingCounter++;
            continue;
        }
        Console.WriteLine("error");
    }
    else if (command[0] == "Update")
    {
        string[] plantInformation = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
        string plantName = plantInformation[0];

        if (plants.ContainsKey(plantName))
        {
            int newRarity = int.Parse(plantInformation[1]);
            plants[plantName].Rarity = newRarity;
            continue;
        }
        Console.WriteLine("error");
    }
    else if (command[0] == "Reset")
    {
        string[] plantInformation = command[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
        string plantName = plantInformation[0];

        if (plants.ContainsKey(plantName))
        {
            plants[plantName].Rating = 0;
            plants[plantName].RatingCounter = 0;
            continue;
        }
        Console.WriteLine("error");
    }
}
Console.WriteLine("Plants for the exhibition:");
foreach (var plant in plants)
{
    if (plant.Value.RatingCounter == 0)
    {
        Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.Rating:f2}");
    }
    else
    {
        Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.Rating / plant.Value.RatingCounter:f2}");
    }
}


class PlantInformation
{
    public PlantInformation(int rarity, double rating, int ratingCounter)
    {
        Rarity = rarity;
        Rating = rating;
        RatingCounter = ratingCounter;
    }

    public int Rarity { get; set; }

    public double Rating { get; set; }

    public int RatingCounter { get; set; }
}