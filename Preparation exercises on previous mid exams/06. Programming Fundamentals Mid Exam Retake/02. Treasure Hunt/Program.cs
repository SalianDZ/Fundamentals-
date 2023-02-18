using System.Diagnostics.Metrics;

List<string> treasure = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

while (input[0] != "Yohoho!")
{
    string command = input[0];

    if (command == "Loot")
    {
        for (int i = 1; i <= input.Length - 1; i++)
        {
            if (!treasure.Contains(input[i]))
            {
                treasure.Insert(0, input[i]);
            }
        }
    }
    else if (command == "Drop")
    {
        int index = int.Parse(input[1]);
        if (index >= 0 && index <= treasure.Count - 1)
        {
            string currentLoot = treasure[index];
            treasure.RemoveAt(index);
            treasure.Add(currentLoot);
        }
    }
    else if (command == "Steal")
    {
        int count = int.Parse(input[1]);
        int startIndex = treasure.Count - count;
        if (startIndex < 0)
        { 
            startIndex = 0;
        }
        int endIndex = treasure.Count - 1;
        List<string> stolenLoot = new List<string>();

        if (count > treasure.Count)
        {
            count = treasure.Count;
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            stolenLoot.Add(treasure[i]);
        }
        treasure.RemoveRange(startIndex, count);
        Console.WriteLine(String.Join(", ", stolenLoot));
    }


    input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}

int lengthSum = 0;
int counter = 0;

if (treasure.Count > 0)
{
    for (int i = 0; i < treasure.Count; i++)
    {
        lengthSum += treasure[i].Length;
        counter++;
    }
    double average = (lengthSum * 1.0) / counter;
    Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
}
else
{
    Console.WriteLine("Failed treasure hunt.");
}

