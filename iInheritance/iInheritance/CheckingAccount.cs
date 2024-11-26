using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iInheritance
{
    internal class CheckingAccount : BankAccount
    {

        public decimal OverDraftLimit { get; set; }

        public CheckingAccount(string accountHolderName, decimal initialBalance, decimal overDraftLimit)
            : base(accountHolderName, initialBalance)
        {
            OverDraftLimit = overDraftLimit;


        }

        public void withdraw(decimal amount)
        {
            if (amount > 0 && Balance - amount >= -OverDraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"{amount:C} withdrawn. New balance : {Balance}");

            }
            else
            {

                Console.WriteLine("Insufficient funds or exceed overdraft limit.");
            }



        }
    }
}
