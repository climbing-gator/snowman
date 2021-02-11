using System;

namespace Snowman
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = string.Empty;
            if (args.Length < 1)
            {
                Console.WriteLine("Please provide a file of words to guess");
                args = new string[] { Console.ReadLine(), };

            }
            filePath = args[0];

            char guessedLetter;
            var words = Words.LoadWords(filePath);
            var snowman = new SnowmanBody();

            while (!snowman.IsComplete() && !words.guessedCorrectWord)
            {
                foreach(var value in words.guessedWord)
                {
                    Console.Write(value + "  ");
                }
                Console.WriteLine();
                Console.WriteLine("Guess a letter..." + Environment.NewLine);
                // TODO: Handle non-letters
                // TODO: Handle more than one char input
                guessedLetter = Console.ReadLine()[0];
                // TODO: convert guess into lowercase or do comparision below disregarding case
                // convert input into either a correct letter that replaces the space or 
                // a wrong guess, which 'draws' a body part
                for(int i = 0; i < words.currentWord.Length; i++)
                {
                    if (words.currentWord[i] == guessedLetter)
                    {
                        words.guessedWord[i] = guessedLetter.ToString();
                    }
                }
                snowman.AddBodyPart();
            }

            if (words.guessedCorrectWord)
            {
                Console.WriteLine(words.currentWord);
                Console.WriteLine("Winner, winner, chicken dinner!! You won!");
            }
            else if (snowman.IsComplete())
            {
                Console.WriteLine("Game over!");
            }
            

        }
    }
}
