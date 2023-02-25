using System.Runtime.CompilerServices;

int numberOfStudents = int.Parse(Console.ReadLine());
List<Student> students = new List<Student>();

for (int i = 0; i < numberOfStudents; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string firstName = input[0];
    string lastName = input[1];
    double grade = double.Parse(input[2]);

    Student student = new Student(firstName, lastName, grade);

    students.Add(student);
}

foreach (var currentStudent in students.OrderByDescending(x => x.Grade))
{
    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName}: {currentStudent.Grade:f2}");
}


public class Student
{
    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
}