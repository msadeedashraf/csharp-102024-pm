using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
            string[] address;
            bool validLength = false;
            bool validZeroes = false;
            bool validRange = false;

            foreach (string ip in ipv4Input)
            {
                address = ip.Split('.', (char)StringSplitOptions.RemoveEmptyEntries);

                ValidateLength();
                ValidateZeroes();
                ValidateRange();

                if (validLength && validZeroes && validRange)
                {
                    Console.WriteLine($"{ip} is a valid IPv4 address");
                }
                else
                {
                    Console.WriteLine($"{ip} is an invalid IPv4 address");
                }
            }

            void ValidateLength()
            {
                validLength = address.Length == 4;
            };

            void ValidateZeroes()
            {
                foreach (string number in address)
                {
                    if (number.Length > 1 && number.StartsWith("0"))
                    {
                        validZeroes = false;
                        return;
                    }
                }

                validZeroes = true;
            }

            void ValidateRange()
            {
                foreach (string number in address)
                {
                    int value = int.Parse(number);
                    if (value < 0 || value > 255)
                    {
                        validRange = false;
                        return;
                    }
                }
                validRange = true;
            }
            /*
            string allStudents = "Iyo-Safar-Alan-Fowsia-Lydia";

            string[] studnets = allStudents.Split('-');


            foreach (string studnet in studnets)
            {

                Console.WriteLine($"Welcome to learning C# {studnet}");
            }
            */




            /*
            Console.WriteLine("Generating random numbers:");
            DisplayRandomNumbers();
            */

            /*
            int[] times = { 900, 1300, 1700, 2100 };
            int diff = 0;

            Console.WriteLine("Enter current GMT");
            int currentGMT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Current Medicine Schedule:");
            DisplayTimes();

            Console.WriteLine("Enter new GMT");
            int newGMT = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            {
                Console.WriteLine("Invalid GMT");
            }
            else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
            {
                diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                AdjustTimes();
            }
            else
            {
                diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
                AdjustTimes();
            }

            Console.WriteLine("New Medicine Schedule:");
            DisplayTimes();

           
            void DisplayTimes()
            {
                // Format and display medicine times 
                foreach (int val in times)
                {
                    string time = val.ToString();
                    int len = time.Length;

                    if (len >= 3)
                    {
                        time = time.Insert(len - 2, ":");
                    }
                    else if (len == 2)
                    {
                        time = time.Insert(0, "0:");
                    }
                    else
                    {
                        time = time.Insert(0, "0:0");
                    }

                    Console.Write($"{time} ");
                }
                Console.WriteLine();
            }

            void AdjustTimes()
            {
                // Adjust the times by adding the difference, keeping the value within 24 hours 
                for (int i = 0; i < times.Length; i++)
                {
                    times[i] = ((times[i] + diff)) % 2400;
                }
            }
            */


            Console.ReadLine();

        }

        static void DisplayRandomNumbers()
        {
            Random abc = new Random();

            for (int i = 1; i<=5; i++)
            {

            Console.WriteLine($"Random Number: {abc.Next(1, 100)}");
            }
           


            
        
        }




    }
}
