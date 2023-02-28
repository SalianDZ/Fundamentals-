using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.__Order_by_Age
{
    internal class Program
    {
        static List<Person> People = new List<Person>();
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] token = input.Split().ToArray();
                if (DoesIDExist(token[1]) == 1)
                {
                    ChangeCredentials(token[1], token[0], int.Parse(token[2]));
                    input = Console.ReadLine();
                    continue;
                }

                People.Add(new Person(token[1], token[0], int.Parse(token[2])));
                input = Console.ReadLine();
            }

            foreach (Person person in People.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }

        }
        public static void ChangeCredentials(string ID, string name, int age)
        {

            List<Person> person = People.Where(x => x.ID == ID).ToList();
            person[0].Age = age;
            person[0].Name = name;
            person[0].ID = ID;
            People.Remove(person[0]);
            People.Add(person[0]);
            //person[]
        }

        public static int DoesIDExist(string ID) => People.Where(x => x.ID == ID).Count();
    }



    public class Person
    {

        public Person(string ID, string name, int age)
        {
            this.ID = ID;
            this.Name = name;
            this.Age = age;
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}