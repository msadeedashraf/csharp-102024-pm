using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator_V1
{
    internal class Calculator
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }

        public Calculator(double operand1, double operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
            
        }
        public virtual double Add() => Operand1 + Operand2;
        public virtual double Subtract() => Operand1 - Operand2;
        public virtual double Multiply() => Operand1 * Operand2;
        
        public virtual double Divide()
        {
            if (Operand2     == 0)
                throw new DivideByZeroException("Division by zero is not allowed");
            return Operand1 / Operand2;

        }

        public double Add(double thirdOperand) => Operand1 +Operand2+ thirdOperand;

    }
}
