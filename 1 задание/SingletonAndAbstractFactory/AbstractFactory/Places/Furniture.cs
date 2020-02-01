using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Furniture
    {
        private float height = 0;
        private float width = 0;
        private float length = 0;
        
        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        public float Width
        {
            get { return width; }
            set { width = value; }
        }

        public float Length
        {
            get { return length; }
            set { length = value; }
        }

        public Furniture(float width, float heigth, float length)
        {
            this.width = width;
            this.height = heigth;
            this.length = length;
        }

        public float ComputeVolume()
        {
            return width * height * length;
        }
    }
}
