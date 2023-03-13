string decryptedMessage = Console.ReadLine();
List<char> messageInChars = new List<char>();
messageInChars.AddRange(decryptedMessage);

while (true)
{
    string[] command = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

	if (command[0] == "Decode")
	{
		break;
	}
	else if (command[0] == "Move")
	{
        int lettersNumber = int.Parse(command[1]);
		char[] temp = new char[lettersNumber];
        for (int i = 0; i < lettersNumber; i++)
		{
			temp[i] = messageInChars[i];
		}
		messageInChars.RemoveRange(0, lettersNumber);
		messageInChars.AddRange(temp);
	}
	else if (command[0] == "Insert")
	{
		int index = int.Parse(command[1]);
		string value = command[2];

		messageInChars.InsertRange(index, value);	
	}
	else if (command[0] == "ChangeAll")
	{
		char substring = char.Parse(command[1]);
		char replacement = char.Parse(command[2]);

        for (int i = 0; i < messageInChars.Count; i++)
		{
			if (messageInChars[i] == substring)
			{
				messageInChars[i] = replacement;
			}
		}
	}
}
Console.WriteLine($"The decrypted message is: {string.Join("", messageInChars)}");