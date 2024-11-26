using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iInheritance
{
    internal class SavingAccount : BankAccount
    {

        public decimal InstrestRate { get; set; }

        public SavingAccount(string accountHolderName, decimal initialBalance, decimal intrestRate)
            : base(accountHolderName, initialBalance)
        {
            InstrestRate = intrestRate;


        }

        public void ApplyIntrest()
        {

            decimal intrest = Balance * InstrestRate / 100;
            Balance += intrest;
            Console.WriteLine($"Intrest of {intrest:C} applied. New Balance : {Balance}");
        }
    }
}
