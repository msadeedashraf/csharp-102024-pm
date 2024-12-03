using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Savings Account
            SavingsAccount savings = new SavingsAccount("Alice", 5000, 2.5m);
            savings.DisplayAccountType();
            savings.DisplayAccountInfo();
            savings.Deposit(1000);
            savings.ApplyInterest();

            


            Console.WriteLine("\n\n");

            // Create a Checking Account
            CheckingAccount checking = new CheckingAccount("Bob", 1000, 500);
            checking.DisplayAccountType();
            checking.DisplayAccountInfo();
            checking.Deposit(500);
            checking.Withdraw(1200);
            checking.Withdraw(900); // Overdraft exceeded

            Console.ReadKey();

        }
    }
}
