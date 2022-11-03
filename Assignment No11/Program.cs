using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No11
{
    public interface IPrintable
    {
        string print();
    }
    public class Employee : IPrintable
    {
        public int id;
        public string name;
        public double salary;
        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public string print()
        {
            return $" id: {id} name :{name} salary: {salary}";
        }
        public class Student : IPrintable
        {
            public int rollno;
            public string name;
            public double percentage;

            public Student(int rollno, string name, double percentage)
            {
                this.rollno = rollno;
                this.name = name;
                this.percentage = percentage;
            }
            public string print()
            {
                return $"rollno: {rollno} name: {name} percentage: {percentage}";
            }


        }
        public class Program
        {
            static void Main(string[] args)
            {
                Employee e1 = new Employee(1, "Kajal", 25000);
                Console.WriteLine(e1.print());

                Student s1 = new Student(1, "Roshani", 75);
                Console.WriteLine(s1.print());
            }
        }
    }
}
