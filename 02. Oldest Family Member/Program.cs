using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    class Family
    {
        public Family()
        {
            this.People = new List<Person>();
        }
        public List<Person> People { get; set; }
        
        public void AddMember(Person person)
        {
                People.Add(person);
        }
        public Person GetOldestMember()
        {
            Person oldestMember = new Person();
            int maxAge = int.MinValue;
            foreach (Person person in People)
            {
                if (person.Age>maxAge)
                {
                    maxAge = person.Age;
                    oldestMember = person;
                }
            }
            return oldestMember;
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int countOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person { Name = name, Age = age};
                family.AddMember(person);
            }
            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
