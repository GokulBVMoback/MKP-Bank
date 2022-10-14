using System;
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
        public Bank(string bankName="MKP Bank")
        {
            BankName=bankName;
            customers = new List<Customer>(NumOfCustomers);
        }

        //Properties
        public string BankName
        {
            get { return BankName; }
            private set { value = BankName; }
        }
        public int NumOfCustomers
        {
            get { return customers.Count; }
        }
    }
}
