string encryptedMessage = Console.ReadLine();

while (true)
{
    string[] command = Console.ReadLine()
        .Split("|", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "Decode")
    {
        break;
    }
    else if (command[0] == "Move")
    {
        int length = int.Parse(command[1]);
        if (length > encryptedMessage.Length)
        {
            continue;
        }
        string substring = encryptedMessage.Substring(0, length);
        encryptedMessage = encryptedMessage.Remove(0 , length);
        encryptedMessage = encryptedMessage.Insert((encryptedMessage.Length), substring);
    }
    else if (command[0] == "Insert")
    {
        int index = int.Parse(command[1]);
        if (index >= 0 && index <= encryptedMessage.Length)
        {
            string value = command[2];
            encryptedMessage = encryptedMessage.Insert(index, value);
        }
    }
    else if (command[0] == "ChangeAll")
    {
        string substring = command[1];
        string replacement = command[2];

        encryptedMessage = encryptedMessage.Replace(substring, replacement);
    }
}

Console.WriteLine($"The decrypted message is: {encryptedMessage}");