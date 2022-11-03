using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No11
{
    public class Loan
    {
        public string Name { get; set; }
    }
    public class Customer
    {
        public string CName { get; set; }
        //public List<Loan> Loans=new List<Loan>();
    }
    public class Account
    {
        public string AName { get; set; }
        public List<Customer> Customers = new List<Customer>();
        public List<Loan> Loans = new List<Loan>();
    }
    public class Program1
    {

        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>()
            {
                new Account
                {
                    AName="Saving",
                       // List<Customer> Customer=new List<Customer>()
                    Customers=
                    {
                        new Customer{CName="c1"},
                        new Customer{CName="c2"},
                    },
                    Loans=
                    {
                        new Loan{Name="Car" },
                        new Loan{Name="Home"}
                    },

                },
                new Account
                {
                    AName="Current",
                    Customers=
                    {
                        new Customer{CName="c5"},

                    },
                    Loans=
                    {
                            new Loan{Name="Personal"},
                            new Loan{Name="Car"},
                    },
                }
            };
            foreach (Account a in accounts)
            {
                Console.WriteLine($"{a.AName}");
                foreach (Customer c in a.Customers)
                {
                    Console.WriteLine($"\t{c.CName}");
                    foreach (Loan l in a.Loans)
                    {
                        Console.WriteLine($"\t\t{l.Name}");
                    }
                }
            }
        }

    }
}

