using System;
using System.Collections;
using System.Text;

namespace GuessingGameTP
{
    class Guess
    {
        ArrayList listofwords = new ArrayList { "moon", "star", "hello", "world", "dog", "cat", "astral", "selene", "jury", "night" };
        Random number = new Random();
        int tries = 0;
        bool guess = true;
        public void game()
        {
            int random = number.Next(0, 9);
            String word = (string)listofwords[random];
            StringBuilder wordtoguess = new StringBuilder(String.Empty.PadLeft(word.Length, '*'));
            Console.WriteLine("Welcome to Word Guessing Game!");
            Console.WriteLine("You have a maximum of 10 tries to guess the word");
            Console.WriteLine("Word to Guess is: " + wordtoguess);
            while (guess == true)
            {
                Console.Write("\nEnter a letter: ");
                tries++;
                char letter = Convert.ToChar(Console.ReadLine());
                letter = Char.ToLower(letter);
                for (int i = 0; i < word.Length; i++)
                {
                    if (letter == word[i])
                    {
                        wordtoguess[i] = letter;
                    }
                }
                Console.WriteLine(wordtoguess.ToString());
                if (wordtoguess.ToString() == word)
                {
                    Console.WriteLine("Congratulations! You win!" + "\nThe word is: " + word);
                    break;
                }
                else
                {
                    Console.WriteLine("Keep Guessing");
                    if (tries == 10)
                    {
                        Console.WriteLine("You have already guessed 10 times, you failed to guess the word :( " + "\nThe word is: " + word);
                        break;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Guess play = new Guess();
            play.game();
        }
    }
}