using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public abstract class Sensor
    {
        protected int sensor = 0;
        public abstract void SetSensorValue(int val);

        public abstract string GetStringValue();
    }
}