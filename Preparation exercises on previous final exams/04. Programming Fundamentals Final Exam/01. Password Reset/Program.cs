string password = Console.ReadLine();

while (true)
{
    string[] currentCommand = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (currentCommand[0] == "Done")
    {
        break;
    }
    else if (currentCommand[0] == "TakeOdd")
    {
        string tempPassword = string.Empty;
        for (int i = 0; i < password.Length; i++)
        {
            if (i % 2 != 0)
            {
                tempPassword += password[i];
            }
        }
        password = tempPassword;
        Console.WriteLine(password);
    }
    else if (currentCommand[0] == "Cut")
    {
        int index = int.Parse(currentCommand[1]);
        int length = int.Parse(currentCommand[2]);

        password = password.Remove(index, length);
        Console.WriteLine(password);
    }
    else if (currentCommand[0] == "Substitute")
    {
        string substring = currentCommand[1];
        string substitude = currentCommand[2];

        if (password.Contains(substring))
        {
            password = password.Replace(substring, substitude);
            Console.WriteLine(password);
        }
        else
        {
            Console.WriteLine("Nothing to replace!");
        }
    }
}
Console.WriteLine($"Your password is: {password}");