using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    public abstract class Account
    {
        //Data fields
        protected Guid accountId;
        protected double balance;

        //Constructor
        public Account(double Balance)
        {
            accountId = AccountId;
            balance = Balance;
        }

        //Properties
        public Guid AccountId
        {
            get { return accountId; }
            protected set { accountId = new Guid(); }
        }
        public double Balance 
        { 
            get { return balance; } 
            protected set { balance = value; } 
        }

        //Method
        public virtual void Deposit(double depAmt)
        {
                Balance = Balance + depAmt;
        }

        public virtual void Withdraw(double witAmt)
        {
            try
            {
                if (witAmt > Balance)
                {
                    throw new OverdraftException("You cannot withdraw " + witAmt + " amount, due to insufficient balance.", Balance);
                }
                else
                {
                    Balance = Balance - witAmt;
                }
            }
            catch(OverdraftException ex)
            {
                Console.WriteLine("Exception Caught: "+ex.Message);
            }

        }

        //Abstract Method
        public abstract void Display();
    }
}
