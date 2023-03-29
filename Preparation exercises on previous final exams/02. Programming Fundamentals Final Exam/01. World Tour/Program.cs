string destinations = Console.ReadLine();

while (true)
{
    string[] command = Console.ReadLine()
        .Split(":", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "Travel")
    {
        break;
    }
    else if (command[0] == "Add Stop")
    {
        int index = int.Parse(command[1]);

        //A change in the bounds of the index is possible!!!
        if (index >= 0 && index < destinations.Length)
        {
            string stop = command[2];
            destinations = destinations.Insert(index, stop);
            Console.WriteLine(destinations);
            continue;
        }
        Console.WriteLine(destinations);
    }
    else if (command[0] == "Remove Stop")
    {
        int startIndex =int.Parse(command[1]);
        int endIndex =int.Parse(command[2]);

        //A change in the bounds of the index is possible!!!
        if (startIndex >= 0 && endIndex < destinations.Length)
        {
            destinations = destinations.Remove(startIndex, ((endIndex - startIndex) + 1));
            Console.WriteLine(destinations);
            continue;
        }
        Console.WriteLine(destinations);
    }
    else if (command[0] == "Switch")
    {
        string oldString =command[1];
        string newString =command[2];
        if (destinations.Contains(oldString))
        {
            destinations = destinations.Replace(oldString, newString);
            Console.WriteLine(destinations);
            continue;
        }
        Console.WriteLine(destinations);
    }
}
Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");