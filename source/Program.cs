﻿using System;

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

            var words = Words.LoadWords(filePath);

            printSpaces(words.currentWord);
            Console.WriteLine("Guess a letter");
            // TODO: Handle non-letters
            string input = Console.ReadLine();
            // convert input into either a correct letter that replaces the space or 
            // a wrong guess, which 'draws' a body part
            // if no more body parts, print 'game over'
            

        }

        public static void printSpaces(string word)
        {
            foreach (char letter in word)
            {
                Console.Write("___ ");
            }

            Console.Write(Environment.NewLine + Environment.NewLine);
        }
    }
}