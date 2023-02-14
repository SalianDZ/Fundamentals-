int firstEmployeeSttudents = int.Parse(Console.ReadLine());
int secondEmployeeSttudents = int.Parse(Console.ReadLine());
int thirdEmployeeSttudents = int.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());
int hourCounter = 0;

int employeesWorkPerHour = firstEmployeeSttudents + secondEmployeeSttudents + thirdEmployeeSttudents;

while (studentsCount > 0)
{
    hourCounter++;
    if (hourCounter % 4 == 0)
    {
        hourCounter++;
    }
    studentsCount -= employeesWorkPerHour;
}

Console.WriteLine($"Time needed: {hourCounter}h.");
