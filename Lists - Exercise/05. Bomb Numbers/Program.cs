List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> bombInfo = Console.ReadLine().Split().Select(int.Parse).ToList();
int bomb = bombInfo[0];
int bombPowers = bombInfo[1];

while (numbers.Contains(bomb))
{
    int bombIndex = numbers.IndexOf(bomb);
    int startIndex = bombIndex - bombPowers;
    int endIndex = bombIndex + bombPowers;
    if (startIndex < 0)
    {
        startIndex = 0;
    }
    if (endIndex > numbers.Count - 1)
    {
        endIndex = numbers.Count - 1;
        int numbersOut = numbers.Count - (bombPowers * 2);
        numbers.RemoveRange(startIndex, ((numbers.Count - 1) - startIndex) + 1);
        
    }
    else
    {
        numbers.RemoveRange(startIndex, bombPowers * 2 + 1);
    }

}

Console.WriteLine(numbers.Sum());
