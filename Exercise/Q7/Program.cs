using System;

namespace MyApplication
{
    class Member
    {
        public string name = "", address = "";
        public int age;
        public long phoneNo;
        public double salary;
        public void printSalary()
        {
            Console.WriteLine("Salary is: " + salary);
        }

    }
    class Employee : Member
    {
        public string specialization = "";
      

    }

    class Manager : Member
    {
        public string department = "";
        class Program
        {
            static void Main(string[] args)
            {
                Employee obj = new Employee();
                obj.name = "luv";
                obj.age = 20;
                obj.phoneNo = 1234567890;
                obj.address = "Uk";
                obj.salary = 30000;
                obj.specialization = "Developer";
                Console.WriteLine("Name: " + obj.name);
                Console.WriteLine("Age: " + obj.age);
                Console.WriteLine("PhoneNo: " + obj.phoneNo);
                Console.WriteLine("Address: " + obj.address);
                Console.WriteLine("Specialization: " + obj.specialization);
                obj.printSalary();

                Manager per = new Manager();
                per.name = "kush";
                per.age = 21;
                per.phoneNo = 0987654321;
                per.address = "Canada";
                per.salary = 40000;
                per.department = "IT";
                Console.WriteLine();
                Console.WriteLine("Name: " + per.name);
                Console.WriteLine("Age: " + per.age);
                Console.WriteLine("PhoneNo: " + per.phoneNo);
                Console.WriteLine("Address: " + per.address);
                Console.WriteLine("Department: " + per.department);
                per.printSalary();
                Console.ReadLine();
            }
        }
    }
}