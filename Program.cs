using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment3
{
    public class Employee
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public Employee(String name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"Salary:{Salary}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Ankit kumar",24,5000000);
            employee1.Display();
            Console.ReadLine();
        }
    }
}
