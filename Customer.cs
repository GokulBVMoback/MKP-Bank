using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    internal class Customer
    {
        private static int MAXACCOUNTS = 5;
        private List<Accounts> accounts;
        private Guid customerId;
        private string firstName;
        private string lastName;
        
        public Guid CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set {lastName = value;}
        }
        public int NumOfAccounts
            { get { return accounts.Count; } }
    }
}
