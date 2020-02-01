using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Illumination : Sensor
    {
        private float sensor = 0;
        public override float GetSensorValue()
        {
            return sensor;
        }

        public override string GetStringSensorValue()
        {
            return sensor + " lux";
        }

        public override void SetSensorValue(float val)
        {
            sensor = val;
        }
    }
}