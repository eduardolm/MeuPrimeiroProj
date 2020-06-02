using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create a list of customer
            List<Customer> customers = new List<Customer>();
            
            // Create customers to populate the list
            customers.Add(new Customer("Alan", "80911291", "ABC Street", 25.60m));
            customers.Add(new Customer("Bill", "19872131", "DEF Street", -32.1m));
            customers.Add(new Customer("Carl", "29812371", "GHI Street", -12.2m));
            customers.Add(new Customer("David", "78612312", "JKL Street", 12.6m));
            
            // LINQ Query
            var overdue =
                from cust in customers
                where cust.Balance < 0 
                orderby cust.Balance ascending 
                select new {cust.Name, cust.Balance};
            
            // Execute LINQ Query
            foreach (var cust in overdue)
            {
                Console.WriteLine("Name = {0}\tBalance = {1}", cust.Name, cust.Balance);
            }
        }
    }
}