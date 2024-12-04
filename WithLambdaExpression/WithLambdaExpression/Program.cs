using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // A list of numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Use a lambda expression to find all even numbers
            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            // Use a lambda expression to find all odd numbers
            List<int> oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

            // Display the results
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
            Console.WriteLine("Odd Numbers: " + string.Join(", ", oddNumbers));

            Console.ReadLine();
        }
    }
}
