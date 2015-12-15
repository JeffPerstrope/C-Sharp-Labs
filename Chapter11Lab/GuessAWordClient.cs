using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Lab
{
    class GuessAWordClient
    {
        static void Main(string[] args)
        {
            string[] words = {"apricot", "elephant", "tigress",
         "fortunate", "impossible", "historical",
         "colorful", "science"};
            Random RandomClass = new Random();
            int randomNumber;
            randomNumber = RandomClass.Next(0, words.Length);
            string selectedWord = words[randomNumber];
            string guessedWord = "";
            string originalWord = selectedWord;
            string guess;
            char letter;
            int pos;
            char tempChar;
            int foundCount = 0;
            bool letterInWord;
            for (int a = 0; a < selectedWord.Length; ++a)
                guessedWord = guessedWord + "*";
            while (foundCount < selectedWord.Length)
            {
                try
                {
                    Console.WriteLine("Word: {0}", guessedWord);
                    Console.Write("Guess a letter >> ");
                    guess = Console.ReadLine();
                    string oneItem = guess.Substring(0, 1);
                    char oneLetter = Convert.ToChar(oneItem);
                    int numLetter = Convert.ToInt32(oneLetter);
                    if (numLetter < 97 || numLetter > 122)
                    {
                        throw new NonLetterException();
                    }
                    letter = Convert.ToChar(guess.Substring(0, 1));
                    letterInWord = false;
                    for (pos = 0; pos < selectedWord.Length; ++pos)
                    {
                        tempChar = Convert.ToChar(selectedWord.Substring(pos, 1));
                        if (tempChar == letter)
                        {
                            guessedWord = guessedWord.Substring(0, pos) + letter + guessedWord.Substring(pos + 1, (guessedWord.Length - 1 - pos));
                            selectedWord = selectedWord.Substring(0, pos) + '?' + selectedWord.Substring(pos + 1, (guessedWord.Length - 1 - pos));
                            ++foundCount;
                            letterInWord = true;
                        }

                    }
                    if (letterInWord)
                        Console.WriteLine("Yes! {0} is in the word\n", letter);
                    else
                        Console.WriteLine("Sorry. {0} is not in the word\n", letter);
                }
                catch (NonLetterException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Good job! Word was {0}", originalWord);
        }
    }
}
