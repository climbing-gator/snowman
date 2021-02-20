using System;
using Xunit;
using Snowman;
using System.Text;
using System.IO;

namespace SnowmanTests
{
    public class SnowmanWordsTests
    {
        [Fact]
        public void LoadWords_CurrentWordAndGuessedWordHaveCorrectSize()
        {
            string testWord = "apple";
            int testWordSize = testWord.Length;
            byte[] fileContents = Encoding.UTF8.GetBytes(testWord);
            var stream = new MemoryStream(fileContents);
            var filePath = "c://temp//file.txt";
            var words = Words.LoadWords(filePath, stream);

            Assert.Equal(testWordSize, words.currentWord.Length);
            Assert.Equal(testWordSize, words.guessedWord.Length);
        }
    }

}
