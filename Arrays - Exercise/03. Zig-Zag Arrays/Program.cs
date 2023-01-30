int n = int.Parse(Console.ReadLine());

int[] evenNumbers = new int[n];
int[] oddNumbers = new int[n];

for (int i = 0; i < n; i++)
{
    int[] currentNumbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    if (i % 2 == 0)
    {
        oddNumbers[i] = currentNumbers[0];
        evenNumbers[i] = currentNumbers[1];
    }
    else
    {
        evenNumbers[i] = currentNumbers[0];
        oddNumbers[i] = currentNumbers[1]; 
    }
}
for (int z = 0; z < evenNumbers.Length; z++)
{
    Console.Write(oddNumbers[z] + " ");
}
Console.WriteLine();

for (int j = 0; j < evenNumbers.Length; j++)
{
    Console.Write(evenNumbers[j] + " ");
}

