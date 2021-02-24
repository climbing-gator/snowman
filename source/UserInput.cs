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
            return Console.ReadLine();
        }

        public char GetInputFirstCharacterToLower()
        {
            // TODO: Check for null
            lastGuessedChar = Console.ReadLine().ToLower()[0];
            return lastGuessedChar;
        }
    }
}
