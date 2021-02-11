﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Snowman
{
    class Words
    {
        public string currentWord = string.Empty;
        public string [] guessedWord = { };
        public bool guessedCorrectWord = false;
        private const string blankSpace = "_____";
        private List<string> allWords = new List<string> ();
        private int currentWordIndex = 0;
        public Words()
        {
        }

        public static Words LoadWords(string filePath)
        {
            var words = new Words();
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                //TODO: Handle bad filepath, filePath that starts with ""
                using (var reader = new StreamReader(stream))
                {
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        words.allWords.Add(line);
                    }

                }

                words.currentWord = words.allWords[0];
                words.guessedWord = new string[words.currentWord.Length];
                for (int i = 0; i < words.currentWord.Length; i++)
                {
                    words.guessedWord[i] = blankSpace; 
                }
                return words;
            }
        }

        public void GetNextWord()
        {
            if (currentWordIndex++ <= allWords.Count)
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
