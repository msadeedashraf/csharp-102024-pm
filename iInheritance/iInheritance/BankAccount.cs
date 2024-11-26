using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iInheritance
{


    internal class BankAccount
    {
        public string  AccountHolderName { get; set; }
        public decimal  Balance { get; set; }

        //Constructor
        public BankAccount(string accountHolderName, decimal initialBalance) 
        { 

            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount:C} deposited. New balance : {Balance}");

            }
            else {

                Console.WriteLine("Deposit amount must be positive");
                }



        }

        public void DisplayAccountInfo()
        { 
            Console.WriteLine($"Account Holder : {AccountHolderName}, Balance: {Balance:C}"); 
        }
    }

    

    
}
