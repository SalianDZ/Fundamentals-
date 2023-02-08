List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

int minValue = Math.Min(firstList.Count, secondList.Count);

List<int> result = new List<int>();
for (int i = 0; i < minValue; i++)
{
    result.Add(firstList[i]);
    result.Add(secondList[i]);
}

if (firstList.Count > secondList.Count)
{
    for (int i = minValue; i < firstList.Count; i++)
    {
        result.Add(firstList[i]);
    }
}
else if (firstList.Count < secondList.Count)
{
    for (int i = minValue; i < secondList.Count; i++)
    {
        result.Add(secondList[i]);
    }
}
Console.WriteLine(String.Join(" ", result));