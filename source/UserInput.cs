using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    class UserInput : IUserInput
    {
        public char lastGuessedChar;
        public string GetInput()
        {
            var input = Console.ReadLine();
            Console.Clear();
            return input;
        }

        public void ClearLastGuessedChar()
        {
            lastGuessedChar = (char)0;
        }

        public char GetInputFirstCharacterToLower()
        {
            // TODO: Check for null
            lastGuessedChar = Console.ReadLine().ToLower()[0];
            Console.Clear();
            return lastGuessedChar;
        }
    }
}
