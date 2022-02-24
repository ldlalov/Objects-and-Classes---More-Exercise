using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int numOfEmployees = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfEmployees; i++)
            {
                string[] employeeData = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string name = employeeData[0];
                decimal salary = decimal.Parse(employeeData[1]);
                string department = employeeData[2];
                employees.Add(new Employee { Department = department, Name = name, Salary = salary });
                 
            }
        }
    }
}
