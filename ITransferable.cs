using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKPBank
{
    public interface ITransferable
    {
        void Transfer(Account toAccount, double amount);
    }
}
