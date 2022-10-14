﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    public class Customer
    {
        //Data fields
        protected static int MAXACCOUNTS = 5;
        protected List<Account> accounts;
        protected Guid customerId;
        protected string firstName;
        protected string lastName;

        //Constructor
        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            customerId = CustomerId;
            accounts = new List<Account>(MAXACCOUNTS);
        }
        
        //Properties
        public Guid CustomerId
        {
            get { return customerId; }
            protected set { customerId = new Guid(); }
        }
        public string FirstName
        {
            get { return firstName; }
            protected set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            protected set {lastName = value;}
        }
        public int NumOfAccounts
        {
            get { return accounts.Count; } 
        }

        //Methods
        public void AddAccount(Account account)
        {
            if(NumOfAccounts<MAXACCOUNTS)
            {
                accounts.Add(account);
            }
            else
            {
                Console.WriteLine("You cannot add new account, because maximum number of accounts reached");
            }
        }

        public List<Account> GetAccount()
        {
            return accounts;
        }

        public void GetFirstTransferable()
        {
            Console.WriteLine(accounts.FirstOrDefault(x => x.GetType() == typeof(SavingsAccount)));
        }
    }
}
