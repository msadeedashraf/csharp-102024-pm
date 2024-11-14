using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter7
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
           BankAccount savingAccount = new BankAccount("63987563", "Sadeed Ashraf", 1000);

            savingAccount.DisplayAccountInfo();

            savingAccount.Deposit(500);
            savingAccount.Withdrawal(100);
            savingAccount.Withdrawal(1500);
            Console.ReadKey();
        }
    
    
    }
}
