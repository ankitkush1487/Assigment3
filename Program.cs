using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment-3");
            Console.ReadLine();

            Console.WriteLine("Question 1 Solution");
            A3Q1 employee = new A3Q1();
            employee.Employee("Ankit ", 24, 50000m);
            employee.DisplayEmployeeDetails();
            Console.ReadLine();

            Console.WriteLine("Question 2 Solution");
            A3Q2 Account = new A3Q2();
            Account.BankAccount("123456789", "Ankit", 1000.00m);
            Account.Deposit(500.00m);
            Account.Withdraw(200.00m);
            Account.DisplayAccountDetails();
            Account.DisplayAccountDetails();
            Console.ReadLine();

            /*
                        Console.WriteLine("Question 3 Solution");
                        A3Q3 a3Q3 = new AQ3();
                        a3Q3.SimpleATM();
                        Console.ReadLine();

                        Console.WriteLine("Question 4 Solution");
                        A3Q4 a3Q4 = new A3Q4();
                        a3Q4.AverageMarks();
                        Console.ReadLine();

                        Console.WriteLine("Question 5 Solution");
                        A3Q5 a3Q5 = new A3Q5();
                        a3Q5.PasswordValid();
                        Console.ReadLine();

                        Console.WriteLine("Question 6 Solution");
                        A3Q6 a3Q6 = new A3Q6();
                        A3Q6.TaxiRide();
                        Console.ReadLine();

                        Console.WriteLine("Question 7 Solution");
                        A3Q7 A3Q7 = new A3Q7();
                        A3Q7.Attendance();
                        Console.ReadLine();

                        Console.WriteLine("Question 8 Solution");
                        A3Q8 A3Q8 = new A3Q8();
                        A3Q8.Month();
                        Console.ReadLine();

                        Console.WriteLine("Question 9 Solution");
                        A3Q9 A3Q9 = new A3Q9();
                        A3Q9.AddItem("Apple", 10.50m);
                        A3Q9.AddItem("Banana", 5.75m);
                        A3Q9.ViewCart();

                        A3Q9.RemoveItem("Banana");
                        A3Q9.ViewCart();

                        A3Q9.AddItem("Orange", 7.25m);
                        A3Q9.ViewCart();
                        Console.ReadLine();

                        Console.WriteLine("Question 10 Solution");
                        A3Q10 A3Q10 = new A3Q10();
                        A3Q10.Salary();
                        Console.ReadLine();*/
        }
    }

    class A3Q1
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private decimal Salary { get; set; }
        public void Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }


    class A3Q2
    {
        public String Accountnumber { get; set; }
        public String Accountholdername { get; set; }
        public Decimal balance {  get; private set; }

        public void BankAccount(string accountNumber, string accountHolderName, decimal initialBalance)
        {
            Accountnumber = accountNumber;
            Accountholdername = accountHolderName;
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount:C}. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {Accountnumber}");
            Console.WriteLine($"Account Holder: {Accountholdername}");
            Console.WriteLine($"Balance: {balance:C}");
            
        }
    }

}


    class A3Q3
    {
    }

    class A3Q4
    {
    }


    class A3Q5
    {
    }


    class A3Q6
    {
    }
    class A3Q7
    {
    }
    class A3Q8
    {
    }
    class A3Q9
    {
    }
    class A3Q10
    {
    }
