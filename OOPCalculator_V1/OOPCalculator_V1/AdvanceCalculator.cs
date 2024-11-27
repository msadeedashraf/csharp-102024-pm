using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator_V1
{
    internal class AdvanceCalculator : Calculator
    {
        public AdvanceCalculator(double operand1, double operand2)
            :base(operand1, operand2)  {}


        public override double Multiply()
        {
            Console.WriteLine("Advanced Multiplication (Overridden Method):");
            return base.Multiply();  
                }


        public double Modulus()
        {
            if (Operand2 == 0)
                throw new DivideByZeroException("Division by zero is not allowed in modulus");
            return Operand1 % Operand2;

        }

    }
}
