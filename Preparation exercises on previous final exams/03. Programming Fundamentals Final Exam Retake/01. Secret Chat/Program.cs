string secretMessage = Console.ReadLine();

while (true)
{
    string[] command = Console.ReadLine()
        .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "Reveal")
    {
        break;
    }
    else if (command[0] == "InsertSpace")
    {
        int index = int.Parse(command[1]);
        secretMessage = secretMessage.Insert(index, " ");
        Console.WriteLine(secretMessage);
    }
    else if (command[0] == "Reverse")
    {
        string substring = command[1];
        int indexOfSubstring = secretMessage.IndexOf(substring);

        if (secretMessage.Contains(substring))
        {
            secretMessage = secretMessage.Remove(indexOfSubstring, substring.Length);
            char[] charArray = substring.ToCharArray();
            Array.Reverse(charArray);
            string reversedSubstring = new string(charArray);
            secretMessage = secretMessage.Insert((secretMessage.Length), reversedSubstring);
            Console.WriteLine(secretMessage);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    else if (command[0] == "ChangeAll")
    {
        string substring = command[1];
        string replacement =command[2];
        if (secretMessage.Contains(substring))
        {
            secretMessage = secretMessage.Replace(substring, replacement);
        }
        Console.WriteLine(secretMessage);
    }
}
Console.WriteLine($"You have a new text message: {secretMessage}");