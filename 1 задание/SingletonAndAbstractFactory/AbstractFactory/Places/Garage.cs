using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Garage : Place
    {
        private Furniture room = new Furniture(5, 6, 8);
        private Furniture car = new Furniture(3, 3, 6);
        private float volume = 0;

        public override void ComputeVolume()
        {
            volume = room.ComputeVolume() - car.ComputeVolume();
        }

        public override float GetVolume()
        {
            return volume;
        }
    }
}