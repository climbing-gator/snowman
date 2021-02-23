using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    interface IUserInput
    {
        string GetInput();
        char GetInputFirstCharacterToLower();
    }
}
