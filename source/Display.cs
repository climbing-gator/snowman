using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    class Display
    {
        public Display()
        { }

        public void printGuessedWord(Words words)
        {
            foreach (var value in words.guessedWord)
            {
                Console.Write(value + "  ");
            }
        }

        public void printCurrentWord(Words words)
        {
            foreach (var value in words.currentWord)
            {
                Console.Write(value + "  ");
            }
            Console.WriteLine();
        }
        public void printGuessText(Words words)
        {
            this.printGuessedWord(words);
            Console.WriteLine();
            Console.WriteLine("Guess a letter..." + Environment.NewLine);
        }
        public void printNoMoreWordsText()
        {
            Console.WriteLine("No more words to guess. Nicely done. Game over.");
        }
        public void printSnowmanGetsABodyPartText()
        {
            Console.WriteLine("Wrong guess. Snowman gets a body part.");
        }
        public void printSnowmanBuiltText()
        {
            Console.WriteLine("You built the snowman, sad day. Game over!!!");
        }
        public void printWinnerText()
        {
            Console.WriteLine("Winner, winner, chicken dinner!! You won!");
            Console.WriteLine();
        }
        public void printSecretWordText(Words words)
        {
            Console.Write("The secret word was:" + Environment.NewLine);
            this.printCurrentWord(words);
        }
        public void printNotALetterText(char guessedChar)
        {
            Console.WriteLine();
            Console.WriteLine($"{guessedChar} is not a letter. Try again." + Environment.NewLine);
        }
    }
}
