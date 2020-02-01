using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Corridor : Place
    {
        private Furniture room = new Furniture(5, 5, 3);
        private float volume = 0;
        private int doors = 5;
        private float heigthDoor = 3;
        private float widthDoor = 1;

        public override void ComputeVolume()
        {
            room.Length += doors * heigthDoor * widthDoor;
            volume = room.ComputeVolume();
        }

        public override float GetVolume()
        {
            return volume;
        }
    }
}