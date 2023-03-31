using System.Text;

string password = Console.ReadLine();

while (true)
{
    string[] command = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "Done")
    {
        break;
    }
    else if (command[0] == "TakeOdd")
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < password.Length; i++)
        {
            if (i % 2 != 0)
            {
                sb.Append(password[i]);
            }
        }
        password = sb.ToString();
        Console.WriteLine(password);
    }
    else if (command[0] == "Cut")
    {
        int index = int.Parse(command[1]);
        int length = int.Parse(command[2]);

        password = password.Remove(index, length);
        Console.WriteLine(password);
    }
    else if (command[0] == "Substitute")
    {
        string substring = command[1];
        if (password.Contains(substring))
        {
            string substitude = command[2];
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