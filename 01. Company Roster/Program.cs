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
            List<string> departmens = new List<string>();
            int numOfEmployees = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfEmployees; i++)
            {
                string[] employeeData = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string name = employeeData[0];
                decimal salary = decimal.Parse(employeeData[1]);
                string department = employeeData[2];
                employees.Add(new Employee { Department = department, Name = name, Salary = salary });
                //Let's check for Depertment existing
                foreach (Employee employee in employees)
                {
                    if (departmens.Contains(employee.Department))
                    {
                        continue;
                    }
                    departmens.Add(department);
                }
            }
            decimal bestAverageSalary = 0;
            string bestDepartmentName = "";
            List<Employee> bestDepartment = new List<Employee>();
            for (int i = 0; i < departmens.Count; i++)
            {
                decimal averageSalary = 0.00m;
                List<Employee> currenDepartment = new List<Employee>();
                currenDepartment = employees.FindAll(employee => employee.Department == departmens[i]);
                foreach (Employee employee in currenDepartment)
                {
                    averageSalary += employee.Salary;//coding 1106.50  
                }
                if (averageSalary>bestAverageSalary)
                {
                    bestAverageSalary = averageSalary;
                    bestDepartment.Clear();
                    bestDepartment.AddRange(currenDepartment);
                    bestDepartmentName = departmens[i];
                }
            }
            List<Employee> orderedBestDepartment = bestDepartment.OrderByDescending(employee => employee.Salary).ToList();
            Console.WriteLine($"Highest Average Salary: {bestDepartmentName}");
            foreach (Employee employee in orderedBestDepartment)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
}
