using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class Temperature : Sensor
    {
        public override string GetStringValue()
        {
            return sensor + "C";
        }

        public override void SetSensorValue(int val)
        {
            sensor = val;
        }
    }
}