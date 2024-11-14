using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            /*
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);

            Console.WriteLine( Math.Sqrt(5));

            Console.ReadLine();
            */

            /*
            char input;
            do
            {
                input = Convert.ToChar(Console.ReadLine());
                
                Random dice = new Random();

                int roll1 = dice.Next(1, 7);
                int roll2 = dice.Next(1, 7);
                int roll3 = dice.Next(1, 7);

                
                //int roll1 = 3;
                //int roll2 = 3;
                //int roll3 = 3;


                int total = roll1 + roll2 + roll3;

                Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples! +6 bonus to total!");
                    total += 6;
                }
                else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
                {
                    Console.WriteLine("You rolled doubles! +2 bonus to total!");
                    total += 2;
                }








                if (total > 14)
                {
                    Console.WriteLine("You win!");
                    Console.WriteLine("Press any key to continue or 'q' to quit");

                }

                if (total < 15)
                {

                    Console.WriteLine("You Lose");
                    Console.WriteLine("Press any key to continue or 'q' to quit");
                }
            }
            while (input != 'q');
            */


            /*
            string message = "The quick brown fox jumps over the lazy dog.";
            

            bool result = message.Contains("dog");
            Console.WriteLine(result);

            if (message.Contains("fox"))
            {
                Console.WriteLine("What does the fox say?");
            }


            */
            /*
            char input;
            do
            {
                input = Convert.ToChar(Console.ReadLine());
                Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }

                Console.WriteLine($"Your total including the bonus: {total}");
            }

            if (total >= 16)
            {
                Console.WriteLine("You win a new car!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You win a new laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a kitten!");
            }

            }
            while (input != 'q');
            */

            /*
            string[] students = { "Alan", "Fowsia", "CJ", "Hussain"};

            
            foreach (string name in students)
            {
                Console.WriteLine($" Hello {name}, Welcome to CBC!");
            }
            
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($" Hello {students[i]}, Welcome to CBC!");
            }
            */

            /*
            string[] fraudulentIDs = {
            "B123",
            "C234",
            "A345",
            "C15",
            "B177",
            "G3003",
            "C235",
            "B179"
            };

            foreach(string id in fraudulentIDs)
            {

                if (id.StartsWith("B"))
                {
                    Console.WriteLine($"The ID {id} starts with 'B'!");
                }

            }

            */

            int sumAlanScores = 0;

            

            int[] alanScores = { 90,89,91,85,93};

            Console.WriteLine(alanScores[0]);

            

            for (int i = 0; i < alanScores.Length; i++)

                sumAlanScores += alanScores[i];
            }


            //Console.WriteLine($"My score is {sumAlanScores / alanScores.Length}");
            




            Console.ReadLine();

        }
    }
}
