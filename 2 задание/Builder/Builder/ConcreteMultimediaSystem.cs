using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class ConcreteMultimediaSystem : MultimediaSystem
    {
        public override void Display()
        {
            
        }

        public override void PlayAudio()
        {
            
        }

        public override void PlayVideo()
        {
            
        }

        public override void Search(string val)
        {
            
        }

        public override void SetVolume(int val)
        {
            if (val >= 100)
                volume = 100;
            else
                volume = val;
        }
    }
}