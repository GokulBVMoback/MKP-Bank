using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    internal class Bank
    {
        private const int MAXCUSTOMERS = 500;
        private List<Customer> customers;
       public int NumOfCustomers
        {
            get { return customers.Count; }
        }
        public string BankName
        {
            set { value = "MKP Bank";  }
        }
    }
}
