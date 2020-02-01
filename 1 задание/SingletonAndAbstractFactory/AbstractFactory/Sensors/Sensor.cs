using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class Sensor
    {
        public abstract void SetSensorValue(float val);
        public abstract float GetSensorValue();
        public abstract string GetStringSensorValue();
    }
}