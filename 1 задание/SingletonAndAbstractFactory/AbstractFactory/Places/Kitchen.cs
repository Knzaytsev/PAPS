using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Kitchen : Place
    {
        private Furniture room = new Furniture(6, 4, 6);
        private Furniture table = new Furniture(2, 1.5F, 1);
        private Furniture chair = new Furniture(0.5F, 1, 0.5F);
        private int chairs = 2;
        private float volume = 0;

        public override void ComputeVolume()
        {
            volume = room.ComputeVolume() - table.ComputeVolume() - chair.ComputeVolume() * chairs;
        }

        public override float GetVolume()
        {
            return volume;
        }
    }
}