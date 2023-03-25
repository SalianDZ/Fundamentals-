using System.ComponentModel;
using System.Runtime.CompilerServices;

string activationKey = Console.ReadLine();

while (true)
{
    string[] command = Console.ReadLine()
        .Split(">>>").ToArray();

    if (command[0] == "Generate")
    {
        break;
    }
    else if (command[0] == "Contains")
    {
        string substring = command[1];
        if (activationKey.Contains(substring))
        {
            Console.WriteLine($"{activationKey} contains {substring}");
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }
    else if (command[0] == "Flip")
    {
        string part = command[1];
        int startIndex = int.Parse(command[2]);
        int endIndex = int.Parse(command[3]);
        string substring = activationKey.Substring(startIndex, (endIndex - startIndex));
        if (part == "Upper")
        {
            string upperSubstring = substring.ToUpper();
            activationKey = activationKey.Replace(substring, upperSubstring);
        }
        else if (part == "Lower")
        {
            string lowerSubstring = substring.ToLower();
            activationKey = activationKey.Replace(substring, lowerSubstring);
        }

        Console.WriteLine(activationKey);
    }
    else if (command[0] == "Slice")
    {
        int startIndex = int.Parse(command[1]);
        int endIndex = int.Parse(command[2]);

        activationKey = activationKey.Remove(startIndex, (endIndex - startIndex));
        Console.WriteLine(activationKey);
    }
}
Console.WriteLine($"Your activation key is: {activationKey}");