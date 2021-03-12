using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    class SnowmanBody
    {
        private string[] bodyParts = new string[] { "bottom", "middle", "head", "left arm", "right arm", "left eye", "right eye", "mouth", "nose" };
        private List<string> _userSnowman;
        public List<string> userSnowman { private set => _userSnowman = value; get => _userSnowman; }
        public SnowmanBody()
        {
            _userSnowman = new List<string>();
        }

        public void AddBodyPart() 
        {
            if (userSnowman.Count < bodyParts.Length)
            {
                userSnowman.Add(bodyParts[userSnowman.Count]);
            }
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
