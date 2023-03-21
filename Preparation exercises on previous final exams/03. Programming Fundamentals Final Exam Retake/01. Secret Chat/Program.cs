using System.Linq;

string message = Console.ReadLine();
List<char> messageInChars = new List<char>();
messageInChars.AddRange(message);

while (true)
{
    string[] command = Console.ReadLine()
        .Split(":|:", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (command[0] == "Reveal")
    {
        break;
    }
    else if (command[0] == "InsertSpace")
    {
        int index = int.Parse(command[1]);
        messageInChars.Insert(index, ' ');
        Console.WriteLine(string.Join("", messageInChars));
    }
    else if (command[0] == "Reverse")
    {
        string substring = command[1];
        string tempChar =  new string(messageInChars.ToArray());

        if (tempChar.Contains(substring))
        {
            int substringIndex = tempChar.IndexOf(substring);
            messageInChars.RemoveRange(substringIndex, substring.Length);
            char[] substringChar = substring.ToCharArray();
            Array.Reverse(substringChar);
            string reversedSubstring = new string(substringChar);
            messageInChars.AddRange(reversedSubstring);
            Console.WriteLine(string.Join("", messageInChars));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    else if (command[0] == "ChangeAll")
    {
        string substring = command[1];
        string replacement = command[2];
        string tempChar = new string(messageInChars.ToArray());

        if (tempChar.Contains(substring))
        {
            tempChar = tempChar.Replace(substring, replacement);
            messageInChars.Clear();
            messageInChars.AddRange(tempChar);
            Console.WriteLine(string.Join("", messageInChars));
        }
    }
}
Console.WriteLine($"You have a new text message: {string.Join("", messageInChars)}");