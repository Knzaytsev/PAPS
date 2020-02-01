using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public abstract class MultimediaSystem
    {
        protected int volume = 0;
        public abstract void SetVolume(int val);

        public abstract void Display();

        public abstract void PlayVideo();

        public abstract void PlayAudio();

        public abstract void Search(string val);
    }
}