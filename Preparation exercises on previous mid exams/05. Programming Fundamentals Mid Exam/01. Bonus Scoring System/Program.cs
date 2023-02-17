int studentNumbers = int.Parse(Console.ReadLine());
int lectureNumbers = int.Parse(Console.ReadLine());
int additionalPoints = int.Parse(Console.ReadLine());
double maxStudentAttendace = double.MinValue;
double maxStudentLectures = double.MinValue;

for (int i = 0; i < studentNumbers; i++)
{
    double currentStudentAttendance = double.Parse((Console.ReadLine()));

    double totalSum = Math.Round((currentStudentAttendance / lectureNumbers) * (5 + additionalPoints));

    if (totalSum > maxStudentAttendace)
    {
        maxStudentAttendace = totalSum;
        maxStudentLectures = currentStudentAttendance;
    } 
}

Console.WriteLine(value: $"Max Bonus: {maxStudentAttendace}.");
Console.WriteLine($"The student has attended {maxStudentLectures} lectures.");