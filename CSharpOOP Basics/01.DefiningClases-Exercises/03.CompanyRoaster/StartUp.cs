namespace _03.CompanyRoaster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        //this is the 6th task from the homework
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                var employeeTokens = Console.ReadLine().Split().ToArray();
                var name = employeeTokens[0];
                var salary = double.Parse(employeeTokens[1]);
                var position = employeeTokens[2];
                var department = employeeTokens[3];

                if (employeeTokens.Length == 4)
                {
                    employees.Add(new Employee(name, salary, position, department));
                }
                else if (employeeTokens.Length == 5)
                {
                    int age;
                    bool IsAge = int.TryParse(employeeTokens[4], out age);
                    if (IsAge)
                    {
                        employees.Add(new Employee(name, salary, position, department, age));
                    }
                    else
                    {
                        var email = employeeTokens[4];
                        employees.Add(new Employee(name, salary, position, department, email));
                    }
                }
                else
                {
                    var email = employeeTokens[4];
                    var age = int.Parse(employeeTokens[5]);
                    employees.Add(new Employee(name, salary, position, department, email, age));
                }
            }

            var allSalaries = new Dictionary<string, double>();
            foreach (Employee employee in employees)
            {
                var department = employee.department;
                var salary = employee.salary;
                if (!allSalaries.ContainsKey(department))
                {
                    allSalaries[department] = 0.0D;
                }
                allSalaries[department] += salary;
            }

            var highestAvgSalary = double.MinValue;
            var highestPaidDepartment = "";
            foreach (var department in allSalaries.Keys)
            {
                var avgSalary = allSalaries[department] / employees.Where(e => e.department == department).Count();
                if (avgSalary > highestAvgSalary)
                {
                    highestAvgSalary = avgSalary;
                    highestPaidDepartment = department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestPaidDepartment}");
            foreach (Employee employee in employees.Where(e => e.department == highestPaidDepartment).OrderByDescending(e => e.salary))
            {
                var name = employee.name;
                var salary = employee.salary;
                var email = employee.email;
                var age = employee.age;
                Console.WriteLine($"{name} {salary:f2} {email} {age}");
            }
        }
    }
}
