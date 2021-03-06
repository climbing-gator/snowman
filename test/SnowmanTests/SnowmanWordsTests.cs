using System;
using Xunit;
using Snowman;
using System.Text;
using System.IO;

namespace SnowmanTests
{
    public class SnowmanWordsTests: IUserInput
    {
        [Fact]
        public void LoadWords_CurrentWordAndGuessedWordHaveCorrectSize()
        {
            string testWord = "apple";
            int testWordSize = testWord.Length;
            var words = MockLoadFile(testWord);

            Assert.Equal(testWordSize, words.currentWord.Length);
            Assert.Equal(testWordSize, words.guessedWord.Length);
        }

        [Fact]
        public void LoadWords_UserGuessedNonLetter_SnowmanDoesNotGrow()
        {
            //string testWord = "apple";
            //var words = MockLoadFile(testWord);

            //string nonLetter = "5";
            ////TODO: make this a set of parameters
            //using (var stringReader = new StringReader(nonLetter))
            //{
            //    // Mock user input
            //    Console.SetIn(stringReader);
            //}

        }

        [Fact]
        public void LoadWords_UserGuessesMultipleCharacters_SnowmanComparesWholeString()
        {
        // TODO: Treat multiple characters as a guess of whole word
        }

        [Fact]
        public void LoadWords_UserGuessesCorrectWord_DisplayWinnerText() 
        { }

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
        public void LoadWords_UserGuessesAllIncorrectLetters_SnowmanIsBuilt()
        {
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
        public void LoadWords_UserGuessesCorrectLetterTwice_SnowmanDoesNotGrow()
        {
        }

        // This goes in SnowmanBodyTests
        //[Fact]
        // public void TestSnowmanBodyGoesToZerowhenNewWord
        //{}

        // Helper methods/fields

        private Words MockLoadFile(string testWord)
        {
            byte[] fileContents = Encoding.UTF8.GetBytes(testWord);
            var stream = new MemoryStream(fileContents);
            var filePath = "c://temp//file.txt";
            var words = Words.LoadWords(filePath, stream);

            return words;
        }

        public string GetInput()
        {
            return "a";
        }

        public char GetInputFirstCharacterToLower()
        {
            throw new NotImplementedException();
        }
    }

}
