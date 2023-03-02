Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(name))
    {
        students[name] = new List<double>();
    }

    students[name].Add(grade);
}

Dictionary<string, double> goodStudents = new Dictionary<string, double>();

foreach (var (key, value) in students)
{
    double currentStudentGrade = value.Average();
    goodStudents[key] = currentStudentGrade;
}

foreach (var (key, value) in goodStudents.Where(x => x.Value >= 4.50))
{
    Console.WriteLine($"{key} -> {value:f2}");
}

