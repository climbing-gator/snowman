using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    class SnowmanBody
    {
        private string[] bodyParts = new string[] { "bottom", "middle", "head", "left arm", "right arm", "left eye", "right eye", "mouth", "nose" };
        public List<string> userSnowman = new List<string>();
        
        public SnowmanBody()
        { }

        public void AddBodyPart() 
        {
            userSnowman.Add(bodyParts[userSnowman.Count]);
        }

        public void ClearBodyParts()
        {
            userSnowman.Clear();
        }

        public bool IsComplete()
        {
            return userSnowman.Count >= bodyParts.Length;
        }
    }
}
