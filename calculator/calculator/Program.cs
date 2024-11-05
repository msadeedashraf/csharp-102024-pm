using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string myOperator = "A";

            do
            {

                Console.WriteLine("\t\tFour Function Calculator\n");
                Console.WriteLine("Please input your prefered operation \n\t\t A for Addition \n\t\t S for Subtraction \n\t\t D for Divide\n\t\t M for Multiply\n\t\t Q to Quit the program");
                char method = 'A';
                method =  Convert.ToChar(Console.ReadLine());

                myOperator = method.ToString().ToUpper();

                if (myOperator == "A" || myOperator == "D" || myOperator == "S" || myOperator == "M")
                {
                    Console.WriteLine("Please input the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please input the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    if (myOperator == "A")
                    {
                        Console.WriteLine($"Your result after addition is :  {add(num1, num2)}");
                        Console.WriteLine("Press any key to continue calculating...\nYou can press 'Q' to quit");
                        method = Convert.ToChar(Console.ReadLine());
                        myOperator = method.ToString().ToUpper();
                    }
                    else if (myOperator == "D")
                    {
                        Console.WriteLine($"Your result after division is :  {divide(num1, num2)}");
                        Console.WriteLine("Press any key to continue calculating...\nYou can press 'Q' to quit");
                        method = Convert.ToChar(Console.ReadLine());
                        myOperator = method.ToString().ToUpper();
                    }
                    else if (myOperator == "M")
                    {
                        Console.WriteLine($"Your result after multiply is :  {multiply(num1, num2)}");
                        Console.WriteLine("Press any key to continue calculating...\nYou can press 'Q' to quit");
                        method = Convert.ToChar(Console.ReadLine());
                        myOperator = method.ToString().ToUpper();
                    }
                    else if (myOperator == "S")
                    {
                        Console.WriteLine($"Your result after subtraction is :  {subtract(num1, num2)}");
                        Console.WriteLine("Press any key to continue calculating...\nYou can press 'Q' to quit");
                        method = Convert.ToChar(Console.ReadLine());
                        myOperator = method.ToString().ToUpper();
                    }

                }
                else if (myOperator == "Q")
                {
                    Console.WriteLine("Thank you for using the calculator");
                    break;
                   
                }
                else
                {
                    Console.WriteLine("Invalid input press any key to go back to calculator \n\t\t or press Q to quiting the program");
                    method = Convert.ToChar(Console.ReadLine());
                    myOperator = method.ToString().ToUpper();

                }




            }
            while (myOperator != "Q");


            Console.WriteLine("Thank you for using the calculator");

            Console.ReadKey();
        }

        static double add(double num1 , double num2)
        {
            return num1 + num2;
        }
        static double multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        static double subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        static double divide(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}
