using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string accountHolderName, decimal initialBalance, decimal interestRate)
            :base(accountHolderName, initialBalance)
        {
            InterestRate = interestRate;
        }
        // Overriding abstract method
        public override void DisplayAccountType()
        {
            Console.WriteLine("This is a Savings Account.");
        }

        public void ApplyInterest()
        {
            decimal interest = Balance * InterestRate / 100;
            Balance += interest;
            Console.WriteLine($"Interest of {interest:C} applied. New balance: {Balance:C}");
        }



    }
}
