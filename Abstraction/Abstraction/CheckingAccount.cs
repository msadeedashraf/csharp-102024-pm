using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class CheckingAccount :BankAccount
    {
        public decimal OverdraftLimit { get; private set; }
        public CheckingAccount(string accountHolderName, decimal initialBalance, decimal overdraftLimit)
            : base(accountHolderName, initialBalance)
        {
            OverdraftLimit = overdraftLimit;  
        }

        // Overriding abstract method
        public override void DisplayAccountType()
        {
            Console.WriteLine("This is a Checking Account.");
        }
        // Overriding Withdraw method
        public override void Withdraw(decimal amount)
        {
            if (amount > 0 && Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"{amount:C} withdrawn. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or overdraft limit exceeded.");
            }
        }


    }
}
