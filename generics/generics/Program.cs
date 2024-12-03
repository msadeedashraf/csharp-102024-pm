using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var calculator = new Calculator<int>();
            Console.WriteLine($"Addition {calculator.Add(20,30)}");

            var calculator2 = new Calculator<double>();
            Console.WriteLine($"Addition {calculator2.Add(20.30, 30.63)}");
            
            var calculator3 = new Calculator<int>();
            Console.WriteLine($"Addition {calculator3.Divide(20, 0)}");





            Console.ReadLine();

        }
    }
}
