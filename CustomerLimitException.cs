using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    public class CustomerLimitException:Exception
    {
        //Data fields
        protected int numOfCustomers;

        //Constructor
        public CustomerLimitException(string Message, int NumOfCustomers)
            :base(Message)
        {
            numOfCustomers = NumOfCustomers;
        }

        //Properties
        public int NumOfCustomers
        {
            get { return numOfCustomers; }
        }
    }
}
