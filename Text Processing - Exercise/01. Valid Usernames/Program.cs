List<string> usernames = Console.ReadLine().Split(", ").ToList();
bool isValid = true;

foreach (var username in usernames)
{
	if (username.Length >= 3 && username.Length <= 16)
	{
        foreach (char currentChar in username)
        {
            if (!(char.IsLetter(currentChar) || char.IsDigit(currentChar)
                || (currentChar == '-') || (currentChar == '_')))
            {
                isValid = false;
                break;
            }
        }
        if (isValid)
        {
            Console.WriteLine(username);
        }
    }
    isValid = true;
}