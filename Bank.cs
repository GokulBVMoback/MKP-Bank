﻿using System;
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
            get;
            protected set;
        }
        public int NumOfCustomers
        {
            get { return customers.Count; }
        }

        //Methods
        public void AddCustomer(string firstName, string lastName)
        {
                if (NumOfCustomers >= MAXCUSTOMERS)
                {
                    throw new AccountLimitException("You cannot add new customer, because maximum number of customers reached.", NumOfCustomers);
                }
                else
                {
                    Customer customer = new Customer(firstName, lastName);
                    customers.Add(customer);
                }
        }

        public void GenerateReport()
        {
            Console.WriteLine(ToString());
            foreach(Customer customer in customers)
            {
                Console.WriteLine("Full Name:" + customer.FirstName + " " + customer.LastName);
                foreach (Account account in customer.GetAccount())
                {

                    if (account.GetType() == typeof(SavingsAccount) || account.GetType()==typeof(CheckingAccount))
                    {
                        Console.WriteLine("Account Type:" + account.GetType().Name);
                    }
                    else
                    {
                        Console.WriteLine("Account Type:Unknown Account");
                    }
                    Console.WriteLine("Balance:"+account.Balance);
                } 
            }
        }

        public Customer GetCustomer(string firstName, string lastName)
        {
            return customers.Where(x => x.FirstName == firstName && x.LastName == lastName).FirstOrDefault();
        }
        public override string ToString()
        {
            return "Welcome to "+BankName+". Number of customers: "+ NumOfCustomers;     
        }
    }
}
