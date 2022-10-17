﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bank bank = new Bank("MKP Bank");
                Customer customer;
                Account account;
                try
                {
                    
                    bank.AddCustomer("Gokul", "B V");
                    bank.AddCustomer("Renish", "Britto");
                    bank.ToString();
                    
                }
                catch(CustomerLimitException e)
                {
                    Console.WriteLine("Exception Caught"+e.Message, e.NumOfCustomers);
                }
                try
                {
                    customer = bank.GetCustomer("Gokul", "B V");
                    customer.AddAccount(new SavingsAccount(1000, 10));
                    customer.AddAccount(new CheckingAccount(1000));
                    customer = bank.GetCustomer("Renish", "Britto");
                    customer.AddAccount(bank.GetCustomer("Gokul", "B V").GetAccount().Where(x => x.GetType() == typeof(CheckingAccount)).FirstOrDefault());
                    bank.GenerateReport();
                }
                catch (AccountLimitException ex)
                {
                    Console.WriteLine("Exception Caught" + ex.Message, ex.NumOfAccounts);
                }



                customer = bank.GetCustomer("Gokul", "B V");
                account = (bank.GetCustomer("Gokul", "B V").GetAccount().Where(x => x.GetType() == typeof(CheckingAccount)).FirstOrDefault());
                try
                {
                    Console.WriteLine("\nChecking Overdraft");
                   
                    account.Withdraw(20);
                    account.Deposit(20);
                    account.Withdraw(2000);
                }
                catch(OverdraftException e)
                {
                    Console.WriteLine("Exception Caught: " + e.Message, e.DeficitAmount);
                }
                finally
                {
                    Console.WriteLine("First Name:"+customer.FirstName+" Last Name:"+customer.LastName);
                    account.Display();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception Caught"+ex.Message);
            }
        }
    }
}
