﻿using System;

namespace Snowman
{
    class Program
    {
        public static void Main(string[] args)
        {
            string filePath = string.Empty;
            string gameOverText = string.Empty;
            bool gameOver = false;
            var userInput = new UserInput();
            var display = new Display();

            if (args.Length < 1)
            {
                Console.WriteLine("Please provide a file of words to guess");
                args = new string[] { userInput.GetInput(), };
            }
            filePath = args[0];

            char guessedChar;
            //var words = Words.LoadWords(filePath);
            var words = Words.LoadWords("C://Users//Michelle//Desktop//sandbox//words.txt");
            var snowman = new SnowmanBody();

            while (!gameOver)
            {
                display.printGuessText(words);

                guessedChar = userInput.GetInputFirstCharacterToLower();
                Console.Clear();
                display.printGuessedChar(userInput);
                // TODO: I think the if statement ought to be a while statement, as it may not work for multiple non-letter chars
                if (!words.IsCharacterLetter(guessedChar))
                {
                    display.printNotALetterText(guessedChar);
                    display.printGuessText(words);
                    guessedChar = userInput.GetInputFirstCharacterToLower();
                }
                // TODO: convert guess into lowercase or do comparision below disregarding case
                // convert input into either a correct letter that replaces the space or 
                // a wrong guess, which 'draws' a body part
                if (words.GuessedCorrectLetter(guessedChar))
                {
                    for (int i = 0; i < words.currentWord.Length; i++)
                    {
                        if (words.currentWord[i] == guessedChar)
                        {
                            words.guessedWord[i] = guessedChar.ToString();
                        }
                    }

                    if (words.GuessedCorrectWord())
                    {
                        display.printCurrentWord(words);
                        display.printWinnerText();
                        if (words.RemainingWords() > 0)
                        {
                            words.GetNextWord();
                            snowman.ClearBodyParts();
                        }
                        else
                        {
                            gameOver = true;
                            display.printNoMoreWordsText();
                        }
                    }

                }
                else
                {
                    snowman.AddBodyPart();
                    display.printWrongGuessText(snowman);
                }

                if (snowman.IsComplete())
                { 
                    gameOver = true;
                    display.printSnowmanBuiltText();
                    display.printSecretWordText(words);
                }
            }
        }
    }
}
