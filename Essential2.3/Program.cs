using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Sergey", "Lastname");
            employee.Age = -1;
            employee.Position = "Director";
            employee.ShowEmployee();
            Console.ReadKey();
        }
        class Employee
        {
            private string firstName, lastName, position;
            private int age;
            public double Salary
            {
                get
                {
                    double salary;
                    salary = 20000 + 5000 * Age;
                    if (Position == "Director")
                        salary += 10000;
                    return salary;
                }
            }
            public double Nalog { get => Salary * 0.15; }
            public string FirstName { get => firstName; set => firstName = value; }
            public string LastName { get => lastName; set => lastName = value; }
            public string Position { get => position; set => position = value; }
            public int Age { get => age; set => age= value>=0?value:0; }

            public Employee(string first,string last)
            {
                FirstName = first;
                LastName = last;
            }

            public void ShowEmployee()
            {
                Console.WriteLine($"{LastName} {FirstName}\nPosition: {Position ?? "No position"}\nSalary: {Salary}\nTax: {Nalog}");
            }

        }
    }
}
