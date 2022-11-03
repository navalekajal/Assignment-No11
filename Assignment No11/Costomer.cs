using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No11
{
    public interface ICustomer
    {
        string Details();
    }
    public interface IOrder
    {
        string Details();
    }
    public class Transaction : ICustomer, IOrder
    {
        string ICustomer.Details()
        {
            return "Customer details";
        }
        string IOrder.Details()
        {
            return "Order details";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer c = new Transaction();
            Console.WriteLine(c.Details());

            IOrder o = new Transaction();
            Console.WriteLine(o.Details());
        }
    }
}
