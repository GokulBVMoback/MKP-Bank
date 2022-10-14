using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    public class Bank
    {
        //Data fields
        protected const int MAXCUSTOMERS = 500;
        protected List<Customer> customers;

        //Constructor
        public Bank(string bankName)
        {
            BankName=bankName;
            customers = new List<Customer>(MAXCUSTOMERS);
        }

        //Properties
        public string BankName
        {
            get { return BankName; }
            protected set { value = BankName; }
        }
        public int NumOfCustomers
        {
            get { return customers.Count; }
        }

        //Methods
        public void AddCustomer(string firstName, string lastName)
        {
            if(NumOfCustomers>=MAXCUSTOMERS)
            {
                Console.WriteLine("You cannot add new customer, because maximum number of customers reached.");
            }
            else
            {
                Customer customer = new Customer(firstName, lastName);
                customers.Add(customer);
            }
        }

        public void GenerateReport()
        {
            ToString();
            foreach(Customer customer in customers)
            {
                Console.WriteLine("Full Name:" + customer.FirstName + " " + customer.LastName);
                Console.WriteLine("Customer Id:" + customer.CustomerId);
                Console.WriteLine("Number of Accounts:" + customer.NumOfAccounts);
                Console.WriteLine("Account Type:"+customer.GetType().Name);

                //if (customer.GetType() == typeof(SavingsAccount))
                //{
                //    Console.WriteLine("\nAccount Type:Savings Account");
                //}
                //else if (customer.GetType() == typeof(CheckingAccount))
                //{
                //    Console.WriteLine("\nAccount Type:Checking Account");
                //}
                //else
                //{
                //    Console.WriteLine("\nAccount Type:Unknown Account");
                //}   
            }
        }

        public Customer GetCustomer(string firstName, string lastName)
        {
            return customers.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
        public override string ToString()
        {
            BankName = "MKP Bank";
            return BankName + NumOfCustomers;     
        }
    }
}
