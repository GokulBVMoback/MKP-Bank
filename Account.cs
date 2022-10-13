using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    internal abstract class Accounts
    {
        private Guid accountId;
        private double balance;
        public Guid AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public double Balance 
        { 
            get { return balance; } 
            set { balance = value; } 
        }
    }
}
