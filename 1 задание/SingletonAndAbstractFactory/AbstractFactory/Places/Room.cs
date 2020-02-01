using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Room : Place
    {
        private Furniture room = new Furniture(4, 3, 3);
        private float volume = 0;

        public override void ComputeVolume()
        {
            volume = room.ComputeVolume();
        }

        public override float GetVolume()
        {
            return volume;
        }
    }
}