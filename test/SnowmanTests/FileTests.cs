using Xunit;
using Snowman;
using System.Text;
using System.IO;

namespace SnowmanTests
{
    public class FileTests
    {
        [Fact]
        public void UserDoesNotProvideFilePath_PromptForFilePath()
        {
        }

        [Fact]
        public void UserProvidesFilePathWithInvalidCharacters_PromptForValidFilePath()
        {
        }

        [Fact]
        public void UserProvidesFilePathToInvalidLocation_PromptForValidFilePath()
        {
        }
    }

}
