using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal interface ITransaction
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }
}
