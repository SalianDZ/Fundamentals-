using System;
namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int courses = peopleNumber / elevatorCapacity;

            if (peopleNumber % elevatorCapacity != 0)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}