using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No11
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Branch
    {
        public int BId { get; set; }
        public string BName { get; set; }
        public List<Student> Stud = new List<Student>();
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Branch> branches = new List<Branch>()
            {
               new Branch
               {
                  BId = 101,
                  BName = "cs",
                  Stud =
                  { 
                   new Student { Name = "s1" },
                   new Student { Name = "s2" },
                   new Student { Name = "s3" },
                   new Student { Name = "s4" },
                   new Student { Name = "s5" },
                   new Student { Name = "s6" }
                  }
               },
               new Branch
               {
                  BId = 102,
                  BName = "IT",
                  Stud =
                  {
                    new Student { Name = "s7" },
                    new Student { Name = "s8" },
                    new Student { Name = "s9" },
                    new Student { Name = "s10" },
                    new Student { Name = "s11" },
                    new Student { Name = "s12" },
                  }
               }
            };
            foreach (Branch b in branches)
            {
                Console.WriteLine($"{b.BId} {b.BName}");
                foreach (Student s in b.Stud)
                {
                    Console.WriteLine($"\t{s.Name}");
                }
            }
        }
    }
}

