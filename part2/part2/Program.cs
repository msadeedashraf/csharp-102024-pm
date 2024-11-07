using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random dice = new Random();

            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");
            */

            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);

            Console.WriteLine( Math.Sqrt(5));

            Console.ReadLine();



        }
    }
}
