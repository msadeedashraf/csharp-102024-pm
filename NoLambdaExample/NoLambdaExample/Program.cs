using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLambdaExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            
            //Without Lambda Expression

            List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10};

            List<int> evenNumbers = numbers.Where(IsEven).ToList();
            List<int> oddNumbers = numbers.Where(IsOdd).ToList();

            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

            Console.WriteLine("Even Numbers: " + string.Join(", ", oddNumbers));

            


            /*
            foreach (int number in numbers) { 
            Console.WriteLine(number);
            }
            */

            Console.ReadLine();

        }


        static bool IsEven(int number)
        { return number % 2 == 0;}

        static bool IsOdd(int number)
        { return number % 2 != 0; }





    }
}
