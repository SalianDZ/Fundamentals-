string startingLocations = Console.ReadLine();
List<char> locationsInChars = new List<char>();
locationsInChars.AddRange(startingLocations);

while (true)
{
    string[] command = Console.ReadLine()
        .Split(":", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "Travel")
    {
        Console.WriteLine($"Ready for world tour! Planned stops: {String.Join("", locationsInChars)}");
        break;
    }
    else if (command[0] == "Add Stop")
    {
        int index = int.Parse(command[1]);
        string currentString = command[2];

        if (index >= 0 && index < locationsInChars.Count)
        {
            locationsInChars.InsertRange(index, currentString);
        }
        Console.WriteLine(String.Join("", locationsInChars));
    }
    else if (command[0] == "Remove Stop")
    {
        int startIndex = int.Parse(command[1]);
        int endIndex = int.Parse(command[2]);

        if (startIndex >=0 && endIndex < locationsInChars.Count)
        {
            locationsInChars.RemoveRange(startIndex, (endIndex - startIndex + 1));
        }
        Console.WriteLine(String.Join("", locationsInChars));
    }
    else if (command[0] == "Switch")
    {
        string oldString = command[1];
        string newString = command[2];
        int indexOfOldString = locationsInChars.IndexOf(oldString[0]);

        if (new string(locationsInChars.ToArray()).Contains(oldString))
        {
            locationsInChars.InsertRange(indexOfOldString, newString);
            indexOfOldString = locationsInChars.IndexOf(oldString[0]);
            locationsInChars.RemoveRange(indexOfOldString, oldString.Length);
        }
        Console.WriteLine(String.Join("", locationsInChars));
    }
}