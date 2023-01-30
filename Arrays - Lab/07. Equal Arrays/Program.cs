using System.Globalization;

int[] firstArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] secondArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int counter = 0;

int sum = 0;

for (int i = 0; i < firstArray.Length; i++)
{
    sum += firstArray[i]; 
    if (firstArray[i] != secondArray[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        break;
    }
    else
    {
        counter++;
    }
}
if (counter == firstArray.Length)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}
