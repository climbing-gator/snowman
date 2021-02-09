using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    class Words
    {
        public string currentWord = string.Empty;
        private string[] allWords = new string[] { };
        private int currentWordIndex = 0;
        public Words()
        {
        }

        public static Words LoadWords(string filePath)
        {
            //stream = File.Open(filePath);
            // foreach (line in stream){allWords[] = line}
            //currentWord = allWords[currentWordIndex];
            return new Words();
        }

        public void GetNextWord()
        {
            if (currentWordIndex++ <= allWords.Length)
            {
                currentWord = allWords[++currentWordIndex];
            }
            else
            {
                Console.WriteLine("Game over. No more words to guess.");
            }
        }
    }
}
