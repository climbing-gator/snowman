using Snowman;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace SnowmanTests
{
    public class DisplayTests
    {
        [Fact]
        public void LoadWords_UserGuessesIncorrectLetter_DisplayWrongLetterText()
        {
            string testWord = "apple";
            var words = MockLoadFile(testWord);

            using (var writer = new StringWriter())
            {
                using (var reader = new StringReader("x"))
                {
                    Console.SetIn(reader);
                    Console.SetOut(writer);

                    var displayText = writer.ToString();

                    Assert.StartsWith("l", displayText);
                }
            }
        }

        [Fact]
        public void LoadWords_UserGuessesAllIncorrectLetters_DisplayGameOverText()
        {
        }

        [Fact]
        public void LoadWords_UserGuessesCorrectLetterTwice_DisplayNotification()
        {
        }

        [Fact]
        public void LoadWords_UserGuessesCorrectWord_DisplayWinnerText()
        {
        }

        private Words MockLoadFile(string testWord)
        {
            byte[] fileContents = Encoding.UTF8.GetBytes(testWord);
            var stream = new MemoryStream(fileContents);
            var filePath = "c://temp//file.txt";
            var words = Words.LoadWords(filePath, stream);

            return words;
        }
    }
}
