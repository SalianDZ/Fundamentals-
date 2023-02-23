List<Student> students = new List<Student>();

while (true)
{
    string[] studentInfo = Console.ReadLine().Split();

    if (studentInfo[0] == "end")
    { 
        break;
    }
    string firstName = studentInfo[0];
    string lastName = studentInfo[1];
    int age = int.Parse(studentInfo[2]);
    string town = studentInfo[3];

    Student student = new Student()
    {
        firstName = firstName,
        lastName = lastName,
        age = age,
        town = town
    };

    students.Add(student);
}

string searchedTown = Console.ReadLine();
foreach (var eachStudent in students)
{
    if (eachStudent.town == searchedTown)
    {
        Console.WriteLine($"{eachStudent.firstName} {eachStudent.lastName} is {eachStudent.age} years old.");
    }
}

class Student
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public string town { get; set; }

}
