using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    public class CheckingAccount:Account
    {
        //Data Fields
        private double overdraftBalance;

        //Constructor
        public CheckingAccount(double intBal, double overBal)
            :base(intBal)
        {
            Balance=intBal;
            overdraftBalance = overBal;  
        }

        public CheckingAccount(double intBal)
            :this(intBal,0)
        {

        }

        //Methods
        public override void Display()
        {
            Console.WriteLine("Account Id:" + AccountId);
            Console.WriteLine("OverdraftBalance: " + overdraftBalance);
            Console.WriteLine("Initial Balance:" + Balance);
        }
    }
}
