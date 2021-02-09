using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    class SnowmanBody
    {
        private string[] bodyParts = new string[] { "bottom", "middle", "head", "left arm", "right arm", "left eye", "right eye", "mouth", "nose" };
        private int numberOfSnowmanParts = 0;
        
        public SnowmanBody()
        { }

        public void AddBodyPart() 
        {
            numberOfSnowmanParts++;
        }

        public bool IsSnowmanComplete()
        {
            if (numberOfSnowmanParts == bodyParts.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
