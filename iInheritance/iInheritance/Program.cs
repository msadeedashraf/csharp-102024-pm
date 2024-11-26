using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            SavingAccount savings = new SavingAccount("Alan", 5000, 2.5m);
            savings.DisplayAccountInfo();
            savings.Deposit(1000);
            savings.ApplyIntrest();


            CheckingAccount checking = new CheckingAccount("CJ", 1000, 500);
            checking.DisplayAccountInfo();
            checking.withdraw(1200);
            checking.withdraw(500);

            Console.ReadLine();


            /*
             Explanation:
                Base Class (BankAccount): Contains common properties (AccountHolderName, Balance) and methods (Deposit, DisplayAccountInfo) shared by all account types.
                Derived Classes:
                SavingsAccount: Adds an InterestRate and a method to apply interest.
                CheckingAccount: Adds an OverdraftLimit and a method to withdraw money considering the overdraft.
                Main Program:
                A savings account is created, and interest is applied after a deposit.
                A checking account is created, and withdrawals are tested within and exceeding the overdraft limit.
             */


        }
    }
}
