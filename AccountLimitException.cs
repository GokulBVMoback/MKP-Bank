using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    public class AccountLimitException:Exception
    {
        //Data fields
        protected int numOfAccounts;

        //Constructor
        public AccountLimitException(string Message, int NumOfAccounts)
            :base(Message)
        {
            numOfAccounts= NumOfAccounts;
        }

        //Properties
        public int NumOfAccounts
        {
            get { return numOfAccounts; }
        }
    }
}
