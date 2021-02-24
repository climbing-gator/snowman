using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    class UserInput : IUserInput
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }

        public char GetInputFirstCharacterToLower()
        {
            // TODO: Check for null
            return Console.ReadLine().ToLower()[0];
        }
    }
}
