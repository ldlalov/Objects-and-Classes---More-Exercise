using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    class Family
    {
        public List<Person> people = new List<Person>();
        public void AddMember()
        {

        }
        public Person GetOldestMember()
        {
            return Person;
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
            Console.WriteLine("Hello World!");
        }
    }
}
