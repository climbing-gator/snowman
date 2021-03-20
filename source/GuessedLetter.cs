using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    public enum GuessedLetterState
    {
        WrongLetter,
        CorrectLetter,
        CorrectWord,
        NotALetter,
        NoGuessYet
    }
}
