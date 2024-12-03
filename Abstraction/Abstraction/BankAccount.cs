using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class BankAccount : ITransaction
    {

        public string  AccountHolderName { get; private set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string accountHolderName, decimal initialBalance )
        {
            AccountHolderName = accountHolderName;
            Balance = initialBalance;

        }
        public abstract void DisplayAccountType();

        public virtual void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount:C} deposited. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public virtual void Withdraw(decimal amount)
        {
            Console.WriteLine("Withdraw method is not implemented for this account type.");
        }



        // Common method for displaying account information
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolderName}, Balance: {Balance:C}");
        }



    }
}
