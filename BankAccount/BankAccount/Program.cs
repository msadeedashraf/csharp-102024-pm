using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Program
    {
        static double accountBalance = 1000;

        static void Main(string[] args)
        {


            string transactionType;

            Console.WriteLine($"My Bank balance is : {accountBalance}$");

              
            do
            {

                Console.WriteLine($"Press 'D' for deposit and 'W' for Withdrawal");
                transactionType = Convert.ToString(Console.ReadLine());

                if (transactionType == "D")
                {
                    Console.WriteLine("Enter the Deposit Amount:");
                    double credit = Convert.ToDouble(Console.ReadLine());

                    deposit(credit);
                    Console.WriteLine($"My New Bank balance is : {accountBalance}$");
                }
                else if (transactionType == "W")
                {
                    Console.WriteLine("Enter the Withdrawal Amount:");
                    double debit = Convert.ToDouble(Console.ReadLine());

                    withdraw(debit);
                    Console.WriteLine($"My New Bank balance is : {accountBalance}$");
                }
                else
                {
                    
                    Console.WriteLine($"Wrong Input");
                    Console.WriteLine($"Press 'D' for deposit and 'W' for Withdrawal \n Any Key to quit");
                    transactionType = Convert.ToString(Console.ReadLine());
                }
               

            }

            while (transactionType == "D" || transactionType == "W");
            


            //withdraw(100);
            //Console.WriteLine($"My Bank balance is : {accountBalance}$");
            //deposit(500);
            //Console.WriteLine($"My Bank balance is : {accountBalance}$");



            Console.ReadKey();
        }

        static double withdraw(double amount)
        {
            return accountBalance -= amount; 
        }

        static double deposit(double amount)
        {
            return accountBalance += amount;
        }


    }
}
