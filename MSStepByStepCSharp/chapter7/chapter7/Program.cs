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
            /*
           BankAccount savingAccount = new BankAccount("63987563", "Sadeed Ashraf", 1000);
           BankAccount foriegnCurrencyAccount = new BankAccount("63987563", "Sadeed Ashraf", 1000);

            savingAccount.DisplayAccountInfo();

            savingAccount.Deposit(500);
            savingAccount.Withdrawal(100);
            savingAccount.Withdrawal(1500);
            */

            LibraryBook book = new LibraryBook("100 Million $ Offer", "Adam", "23156498", 3);
            book.DisplayBookInfo();

            book.CheckOut();
            book.CheckOut();
            book.CheckOut();
            book.CheckOut();
            //book.ReturnBook();
            book.DisplayBookInfo();
            book.ReturnBook();
            book.DisplayBookInfo();


            Console.ReadKey();
        }
    
    
    }
}
