string key = Console.ReadLine();

while (true)
{
    string[] command = Console.ReadLine()
        .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "Generate")
    {
        break;
    }
    else if (command[0] == "Contains")
    {
        string substring = command[1];

        if (key.Contains(substring))
        {
            Console.WriteLine($"{key} contains {substring}");
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }
    else if (command[0] == "Flip")
    {
        if (command[1] == "Upper")
        {
            int startIndex = int.Parse(command[2]);
            int endIndex = int.Parse(command[3]);
            string substring = key.Substring(startIndex, endIndex - startIndex);
            string newSubstring = substring.ToUpper();
            key = key.Replace(substring, newSubstring);
            Console.WriteLine(key);
        }
        else
        {
            int startIndex = int.Parse(command[2]);
            int endIndex = int.Parse(command[3]);
            string substring = key.Substring(startIndex, endIndex - startIndex);
            string newSubstring = substring.ToLower();
            key = key.Replace(substring, newSubstring);
            Console.WriteLine(key);
        }
    }
    else if (command[0] == "Slice")
    {
        int startIndex = int.Parse(command[1]);
        int endIndex = int.Parse(command[2]);
        key = key.Remove(startIndex, endIndex - startIndex);
        Console.WriteLine(key);
    }
}
Console.WriteLine($"Your activation key is: {key}");