int days = int.Parse(Console.ReadLine());
int plunderForADay = int.Parse(Console.ReadLine());
int expectedPlunder = int.Parse(Console.ReadLine());
double plunderSum = 0;

for (int i = 1; i <= days; i++)
{
    plunderSum += plunderForADay;

    if (i % 3 == 0)
    {
        plunderSum += plunderForADay * 0.5;
    }
    if (i % 5 == 0)
    {
        plunderSum -= plunderSum * 0.3;
    }
}

if (plunderSum >= expectedPlunder)
{
    Console.WriteLine($"Ahoy! {plunderSum:f2} plunder gained.");
}
else
{
    double percentage = (plunderSum / expectedPlunder) * 100;
    Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
}