using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    class Display
    {
        public Display()
        { }

        //TODO: Clean this up
        public void printUI(Words words, SnowmanBody snowman, UserInput userInput, GuessedLetterState guessedLetterState)
        {
            Console.Clear();
            printGuessedWord(words);
            printGuessedChar(userInput);
            if (!snowman.IsComplete())
            {
                switch (guessedLetterState)
                {
                    case GuessedLetterState.WrongLetter:
                        printWrongGuessText();
                        break;
                    case GuessedLetterState.CorrectLetter:
                        //for (int i = 0; i < words.currentWord.Length; i++)
                        //{
                        //    if (words.currentWord[i] == userInput.lastGuessedChar)
                        //    {
                        //        words.guessedWord[i] = userInput.lastGuessedChar.ToString();
                        //    }
                        //}
                        printCorrectGuessText(userInput);
                        break;
                    case GuessedLetterState.NotALetter:
                        printNotALetterText(userInput);
                        break;
                    case GuessedLetterState.CorrectWord:
                        printWinnerText(words);
                        break;
                    case GuessedLetterState.NoGuessYet:
                        break;
                }
                printSnowmanBodyParts(snowman);
                if (!words.GuessedCorrectWord())
                {
                    printGuessText();
                }
            }
            else
            {
                printSnowmanBuiltText();
                printSecretWordText(words);
            }
        }

        public void printGuessedWord(Words words)
        {
            Console.WriteLine("The Secret Word:" + Environment.NewLine);
            foreach (var value in words.guessedWord)
            {
                Console.Write(value + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public void printCurrentWord(Words words)
        {
            Console.WriteLine();
            foreach (var value in words.currentWord)
            {
                Console.Write(value + "  ");
            }
            Console.WriteLine();
        }

        public void printFileRequestText()
        {
            Console.WriteLine("Please provide a file of words to guess");
        }

        public void printGuessText(Words words)
        {
            this.printGuessedWord(words);
            Console.WriteLine();
            Console.WriteLine("Guess a letter..." + Environment.NewLine);
        }
        public void printGuessText()
        {
            Console.WriteLine("Guess a letter..." + Environment.NewLine);
        }

        public void printGuessedChar(UserInput userInput)
        {
            //TODO Check for null
            Console.WriteLine($"You guessed the letter: {userInput.lastGuessedChar}" + Environment.NewLine);
        }

        public void printCorrectGuessText(UserInput userInput)
        {
            Console.WriteLine($"Good guess! The letter you guessed \"{userInput.lastGuessedChar}\" is in the secret word." + Environment.NewLine);
        }
        public void printNoMoreWordsText()
        {
            Console.WriteLine("No more words to guess. Nicely done. Game over.");
        }
        public void printWrongGuessText(SnowmanBody snowman)
        {
            printSnowmanGetsABodyPartText();
            Console.WriteLine();
            printSnowmanBodyParts(snowman);
        }

        public void printWrongGuessText()
        {
            printSnowmanGetsABodyPartText();
            Console.WriteLine();
        }
        public void printSnowmanBodyParts(SnowmanBody snowman)
        {
            if (snowman.userSnowman.Count == 0)
            {
                Console.WriteLine("Your snowman has no parts yet");
            }
            else
            {
                Console.WriteLine("Your snowman has the following body parts:");
                for (int i = snowman.userSnowman.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(snowman.userSnowman[i]);
                }
            }
            Console.WriteLine();
        }
        public void printSnowmanGetsABodyPartText()
        {
            Console.WriteLine("Wrong guess. Snowman gets a body part.");
        }
        public void printSnowmanBuiltText()
        {
            Console.WriteLine("You built the snowman, sad day. Game over!!!");
        }
        public void printWinnerText(Words words)
        {
            Console.WriteLine();
            Console.WriteLine($"Winner, winner, chicken dinner!! You won! You guessed the secret word: {words.currentWord}");
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
        public void printNotALetterText(UserInput userInput)
        {
            Console.WriteLine();
            Console.WriteLine($"{userInput.lastGuessedChar} is not a letter. Try again." + Environment.NewLine);
        }
    }
}
