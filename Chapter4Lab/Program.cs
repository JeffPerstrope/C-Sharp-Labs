using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock (r), Paper (p), or Scissors (s)? ");
            string userChoice = Console.ReadLine();
            int numChoice = 0;
            Random ranChoiceGenerator = new Random();
            int randomChoice;
            randomChoice = ranChoiceGenerator.Next(1, 4);

            if (userChoice.Equals("r"))
                numChoice = 1;
            if (userChoice.Equals("p"))
                numChoice = 2;
            if (userChoice.Equals("s"))
                numChoice = 3;

            if (numChoice == 1 && randomChoice == 1)
                Console.WriteLine("Rock vs. Rock, Tie");
            if (numChoice == 1 && randomChoice == 2)
                Console.WriteLine("Rock vs. Paper, You lose");
            if (numChoice == 1 && randomChoice == 3)
                Console.WriteLine("Rock vs. Scissors, You win");
            if (numChoice == 2 && randomChoice == 1)
                Console.WriteLine("Paper vs. Rock, You win");
            if (numChoice == 2 && randomChoice == 2)
                Console.WriteLine("Paper vs. Paper, Tie");
            if (numChoice == 2 && randomChoice == 3)
                Console.WriteLine("Paper vs. Scissors, You lose");
            if (numChoice == 3 && randomChoice == 1)
                Console.WriteLine("Scissors vs. Rock, You lose");
            if (numChoice == 3 && randomChoice == 2)
                Console.WriteLine("Scissors vs. Paper, You win");
            if (numChoice == 3 && randomChoice == 3)
                Console.WriteLine("Scissors vs. Scissors, Tie");
        }
    }
}
