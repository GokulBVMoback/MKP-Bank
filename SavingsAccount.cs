using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    public class SavingsAccount:Account,ITransferable
    {
        //Data fields
        protected double interestRate;

        //Constructor
        public SavingsAccount(double intBal,double intRate)
            :base(intBal)
        {
            Balance=intBal;
            interestRate=intRate;
        }

        //Methods
        public override void Display()
        {
            Console.WriteLine("Account Id:"+AccountId);
            Console.WriteLine("Interest Rate:"+interestRate);
            Console.WriteLine("Balance:"+Balance);
        }

        public void Transfer(Account toAccount, double amount)
        {
            this.Withdraw(amount);
            toAccount.Deposit(amount);
        }
    }
}
