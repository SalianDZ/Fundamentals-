using System.Linq;

string[] firstArray = Console.ReadLine()
    .Split()
    .ToArray();

string[] secondArray = Console.ReadLine()
    .Split()
    .ToArray();


for (int i = 0; i < firstArray.Length; i++)
{
    for (int j = 0; j < secondArray.Length; j++)
    {
        if (secondArray[j] == firstArray[i])
        {
            Console.Write(secondArray[j] + " ");
        }
    }
}