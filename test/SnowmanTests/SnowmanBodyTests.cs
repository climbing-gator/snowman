using Snowman;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SnowmanTests
{
    public class SnowmanBodyTests
    {
        [Fact]
        public void NewUserSnowman_AddBodyPart_SnowmanSizeIncreaseByOne()
        {
            var snowman = new SnowmanBody();
            int snowmanStartingSize = snowman.userSnowman.Count;

            snowman.AddBodyPart();

            Assert.Equal(snowmanStartingSize + 1, snowman.userSnowman.Count);
        }

        [Fact]
        public void UserSnowmanComplete_AddBodyPart_SnowmanSizeDoesNotChange()
        {
            var snowman = new SnowmanBody();
            while (!snowman.IsComplete())
            {
                snowman.AddBodyPart();
            }
            Assert.True(snowman.IsComplete());
            var snowmanSize = snowman.userSnowman.Count;

            snowman.AddBodyPart();

            Assert.Equal(snowmanSize, snowman.userSnowman.Count);
        }

        [Fact]
        public void UserSnowmanWithBodyParts_ClearBodyParts_SnowmanSizeIsZero()
        {
            var snowman = new SnowmanBody();
            snowman.AddBodyPart();
            Assert.True(snowman.userSnowman.Count > 0);

            snowman.ClearBodyParts();

            Assert.True(snowman.userSnowman.Count == 0);
        }
    }
}
