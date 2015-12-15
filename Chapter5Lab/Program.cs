using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1;
            Console.Write("Try to guess the random number: ");
            string userNum = Console.ReadLine();
            int guessNum = Convert.ToInt32(userNum);
            Random ranNumGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumGenerator.Next(1, 11);
            while (guessNum != randomNumber)
            {
                if (guessNum > randomNumber)
                {
                    Console.WriteLine("Too high");
                    total++;
                    Console.Write("Try again: ");
                    userNum = Console.ReadLine();
                    guessNum = Convert.ToInt32(userNum);
                }
                if (guessNum < randomNumber)
                {
                    Console.WriteLine("Too low");
                    total++;
                    Console.Write("Try again: ");
                    userNum = Console.ReadLine();
                    guessNum = Convert.ToInt32(userNum);
                }
            }
            Console.WriteLine("You guessed it in {0} tries", total);
            Console.WriteLine("The number was " + randomNumber);
        }
    }
}
