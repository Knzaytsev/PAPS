﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class Illumination : Sensor
    {
        public override string GetStringValue()
        {
            return sensor + " lux";
        }

        public override void SetSensorValue(int val)
        {
            sensor = val;
        }
    }
}