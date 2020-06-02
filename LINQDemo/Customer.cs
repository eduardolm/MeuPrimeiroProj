using System.Collections.Specialized;

namespace LINQDemo
{
    public class Customer
    {
        private string name;
        private string phone;
        private string address;
        private decimal balance;

        public Customer()
        {
        }

        public Customer(string name, string phone, string address, decimal balance)
        {
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
            this.Balance = balance;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
        
        public decimal Balance { get; set; }
        
    }
}