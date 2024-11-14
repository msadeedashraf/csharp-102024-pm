using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter7
{
    internal class BankAccount
    {
        //Properties
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }

        public decimal Balance { get; set; }

        //Constructor
        public BankAccount(string accountNumber, string accountName, decimal initialBalance)
        {
            AccountNumber = accountNumber;

            AccountName = accountName;

            Balance = initialBalance;

        }

        //Methods
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;

            }

            Balance += amount;
            Console.WriteLine($"Deposit successful. Current balance : {Balance}");


        }

        public void Withdrawal(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;

            }

            if (amount > Balance)
            {
                Console.WriteLine($"Insufficient funds. Trying yo withdraw {amount} but your balance is {Balance}");
                return;

            }


            Balance -= amount;
            Console.WriteLine($"Withdrawal successful. Current balance : {Balance}");


        }

        //Method to display the bank acount info
        public void DisplayAccountInfo() 
        {
            Console.WriteLine("Account Information");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Title of the account: {AccountName}");
            Console.WriteLine($"Balance: {Balance}");

        }   



    }
}
