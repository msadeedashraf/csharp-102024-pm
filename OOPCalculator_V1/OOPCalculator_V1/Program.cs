using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Basic Calculator Example:");

            Calculator basicCalculator = new Calculator(10, 5);
            Console.WriteLine($"Addition: {basicCalculator.Add()}");
            Console.WriteLine($"Subtraction: {basicCalculator.Subtract()}");
            Console.WriteLine($"Multiplication: {basicCalculator.Multiply()}");
            Console.WriteLine($"Division: {basicCalculator.Divide()}");


            Console.WriteLine("\nAdvanced Calculator Example:");
            AdvanceCalculator advancedCalculator = new AdvanceCalculator(10, 3);
            Console.WriteLine($"Addition: {advancedCalculator.Add()}");
            Console.WriteLine($"Subtraction: {advancedCalculator.Subtract()}");
            Console.WriteLine($"Multiplication: {advancedCalculator.Multiply()}"); // Calls overridden method
            Console.WriteLine($"Division: {advancedCalculator.Divide()}");
            Console.WriteLine($"Modulus: {advancedCalculator.Modulus()}");

            Console.WriteLine("\nMethod Overloading Example:");
            Console.WriteLine($"Addition with 3 operands: {basicCalculator.Add(20)}");

            Console.ReadKey();




        }
    }
}
