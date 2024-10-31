using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 50;
            int y = 50;
            int z = 50;
            Console.WriteLine(x + y + z);
            Console.ReadKey();
            */

            /*
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);
            Console.ReadKey();
            */


            /*
             int billAmount = 100;
             int tipAmount = 15;
            int totalBillAmount = billAmount+tipAmount;
            Console.WriteLine(totalBillAmount);
            Console.ReadKey();
             */

            /*
             //Tip Calculator
            Console.WriteLine("Tip Amount\n\n\n");
            Console.WriteLine("##########\n\n\n");
            Console.Write("Please input the Bill Amount: ");
            string billAmount = Console.ReadLine();

            Console.Write("Please input the Tip Amount: ");
            string tipAmount = Console.ReadLine();


            
            int totalBillAmount = int.Parse(billAmount)  + Convert.ToInt32(tipAmount);

            Console.WriteLine("Your Bill Total including the Tip is : " + totalBillAmount);
            Console.ReadKey();
            */


            
             //Loan Calculator
            Console.WriteLine("Loan Calculator\n");
            Console.WriteLine("##########\n");
            Console.Write("Please input the Loan Amount: ");
            string loanAmount = Console.ReadLine();

            Console.Write("Please input the Rate %: ");
            string rate = Console.ReadLine();


            Console.Write("Please input the No. of Months: ");
            string months = Console.ReadLine();




            int monthlyPayment = 1000;

            Console.WriteLine("Your Monthly Payment is : " + monthlyPayment);
            Console.ReadKey();
            



        }
    }
}
