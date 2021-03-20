using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Snowman
{
    public class Words
    {
        //todo: currentWord/guessedword ought to be properties with private setters
        public string currentWord = string.Empty;
        public string[] guessedWord;
        private const string blankSpace = "_____";
        private List<string> allWords = new List<string>();
        private int currentWordIndex = 0;

        public Words()
        {
        }

        public static Words LoadWords(string filePath)
        {
            return LoadWords(filePath, new FileStream(filePath, FileMode.Open, FileAccess.Read));
        }

        internal static Words LoadWords(string filePath, Stream stream)
        {
            using (stream ??= new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var words = new Words();
                using (var reader = new StreamReader(stream))
                {
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        words.allWords.Add(line);
                    }

                }

                words.currentWord = words.allWords[0].ToLower();
                words.guessedWord = new string[words.currentWord.Length];
                words.initializeGuessedWord();
                return words;
            }
        }

        private void initializeGuessedWord()
        {
            guessedWord = new string[currentWord.Length];
            for (int i = 0; i < currentWord.Length; i++)
            {
                guessedWord[i] = blankSpace;
            }
        }

        public bool IsLetterInWord(char guessedLetter)
        {
            return this.currentWord.Contains(guessedLetter);
        }
        public bool IsCharacterLetter(char guessedLetter)
        {
            return char.IsLetter(guessedLetter);
        }
        public bool GuessedCorrectWord()
        {
            var guessedWordConcatenated = string.Empty;
            foreach(string value in guessedWord)
            {
                guessedWordConcatenated = guessedWordConcatenated + value;
            }

            return currentWord.Equals(guessedWordConcatenated);
        }

        public int RemainingWordsCount()
        {
            return allWords.Count - (currentWordIndex + 1);
        }

        public void GetNextWord()
        {
            if (RemainingWordsCount() > 0)
            {
                currentWord = allWords[++currentWordIndex].ToLower();
                initializeGuessedWord();
                //Console.Clear();
                Console.WriteLine("Here comes the next word to guess...");
                //Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Game over. No more words to guess.");
            }
        }
    }
}
