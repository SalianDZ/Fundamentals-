string word = Console.ReadLine();
//char[] wordAsCharArray = word.ToCharArray();
//List<char> wordAsCharList = word.Split().Select(char.Parse).ToList();
List<char> wordAsCharList = new List<char>();
wordAsCharList.AddRange(word);
int power = 0;

for (int i = 0; i < wordAsCharList.Count; i++)
{
	if (wordAsCharList[i] == '>')
	{
        if (wordAsCharList[i + 1] == '>')
        {
            continue;
        }
		char currentPowerAsChar = wordAsCharList[i + 1];
        int currentPower = Convert.ToInt32(new string(currentPowerAsChar, 1));
		power += currentPower;
    }
	else
	{
		if (char.IsDigit(wordAsCharList[i]))
		{
            if (power == 1)
            {
                wordAsCharList.RemoveAt(i);
                i--;
                power --;
            }
            else
            {
                power -= 1;
                wordAsCharList.RemoveAt(i);
                i--;
            }
        }
        else
        {
            if (power <= 0)
            {
                continue;
            }
            else
            {
                wordAsCharList.RemoveAt(i);
                i--;
                power--;
            }
        }
	}
}

Console.WriteLine(String.Join("", wordAsCharList));