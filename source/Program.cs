using System;

namespace Snowman
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = string.Empty;
            string gameOverText = string.Empty;
            bool gameOver = false;
            if (args.Length < 1)
            {
                Console.WriteLine("Please provide a file of words to guess");
                args = new string[] { Console.ReadLine(), };
            }
            filePath = args[0];

            char guessedLetter;
            //var words = Words.LoadWords(filePath);
            var words = Words.LoadWords("C://Users//Michelle//Desktop//sandbox//words.txt");
            var snowman = new SnowmanBody();

            while (!gameOver)
            {
                foreach (var value in words.guessedWord)
                {
                    Console.Write(value + "  ");
                }
                Console.WriteLine();
                Console.WriteLine("Guess a letter..." + Environment.NewLine);

                guessedLetter = Console.ReadLine().ToLower()[0];
                // TODO: convert guess into lowercase or do comparision below disregarding case
                // convert input into either a correct letter that replaces the space or 
                // a wrong guess, which 'draws' a body part
                if (words.currentWord.Contains(guessedLetter))
                {
                    for (int i = 0; i < words.currentWord.Length; i++)
                    {
                        if (words.currentWord[i] == guessedLetter)
                        {
                            words.guessedWord[i] = guessedLetter.ToString();
                        }
                    }

                    if (words.GuessedCorrectWord())
                    {
                        Console.WriteLine(words.currentWord);
                        Console.WriteLine("Winner, winner, chicken dinner!! You won!");
                        if (words.RemainingWords() > 0)
                        {
                            words.GetNextWord();
                            snowman.ClearBodyParts();
                        }
                        else
                        {
                            gameOver = true;
                            gameOverText = "No more words to guess. Nicely done. Game over.";
                        }
                    }

                }
                else
                {
                    snowman.AddBodyPart();
                    Console.WriteLine("Wrong guess. Snowman gets a body part.");
                }

                if (snowman.IsComplete())
                { 
                    gameOver = true;
                    gameOverText = "You built the snowman, sad day. Game over!!!";
                }
            }
            Console.WriteLine(gameOverText);
        }
    }
}
