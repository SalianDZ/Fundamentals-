string text = Console.ReadLine();

while (true)
{
    string[] command = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "Done")
    {
        break;
    }
    else if (command[0] == "Change")
    {
        char charSubstring = char.Parse(command[1]);
        char charReplacement = char.Parse(command[2]);

        text = text.Replace(charSubstring, charReplacement);
        Console.WriteLine(text);
    }
    else if (command[0] == "Includes")
    {
        string substring = command[1];

        if (text.Contains(substring))
        {
            Console.WriteLine("True");
            continue;
        }
        Console.WriteLine("False");
    }
    else if (command[0] == "End")
    {
        string substring = command[1];

        if (text.EndsWith(substring))
        {
            Console.WriteLine("True");
            continue;
        }
        Console.WriteLine("False");
    }
    else if (command[0] == "Uppercase")
    {
        text = text.ToUpper();
        Console.WriteLine(text);
    }
    else if (command[0] == "FindIndex")
    {
        char searchedChar = char.Parse(command[1]);
        int index = text.IndexOf(searchedChar);
        Console.WriteLine(index);
    }
    else if (command[0] == "Cut")
    {
        int startIndex = int.Parse(command[1]);
        int count = int.Parse(command[2]);
        string substring = text.Substring(startIndex, count);
        text = substring;
        Console.WriteLine(text);
    }
}