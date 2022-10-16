using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    public class OverdraftException : Exception
    {
        //Data fields
        protected double deficitAmount;

        //Constructor
        public OverdraftException(string Message, double DeficitAmount)
            :base(Message)
        {
            deficitAmount= DeficitAmount;
        }

        //Properties
        public double DeficitAmount
        {
             get{ return deficitAmount; }
        }
    }
}
