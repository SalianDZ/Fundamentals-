using System.Collections.Immutable;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> removedNumbers = new List<int>();
int numberAtIndex = 0;
while (numbers.Count > 0)
{
    int index = int.Parse(Console.ReadLine());
    if (index < 0)
    {
        index = 0;
        numbers.RemoveAt(0);
        numbers.Insert(0, numbers[numbers.Count - 1]);
        numberAtIndex = numbers[index];
        removedNumbers.Add(numberAtIndex);
    }
    else if (index > numbers.Count - 1)
    {
        index = numbers.Count - 1;
        numbers.RemoveAt(numbers.Count - 1);
        numbers.Add(numbers[0]);
        numberAtIndex = numbers[index];
        removedNumbers.Add(numberAtIndex);
    }
    else
    {
        numberAtIndex = numbers[index];
        removedNumbers.Add(numberAtIndex);
        numbers.RemoveAt(index);
    }
    

    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] <= numberAtIndex)
        {
            numbers[i] += numberAtIndex;
        }
        else if (numbers[i] > numberAtIndex)
        {
            numbers[i] -= numberAtIndex;
        }
    }

}
Console.WriteLine(removedNumbers.Sum());