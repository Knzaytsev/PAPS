using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Temperature : Sensor
    {
        private float temp = 0;
        public override void SetSensorValue(float val)
        {
            temp = val;
        }

        public override float GetSensorValue()
        {
            return temp;
        }

        public override string GetStringSensorValue()
        {
            return temp + "C";
        }
    }
}