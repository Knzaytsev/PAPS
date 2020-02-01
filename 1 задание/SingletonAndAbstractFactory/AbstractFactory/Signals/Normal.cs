using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Normal : Signal
    {
        private float alarm = 0;

        public override void ComputeAlarm(float sensor, float volume)
        {
            alarm = sensor * volume * 0.5F;
        }

        public override bool GetAlarm()
        {
            return alarm >= 500;
        }
    }
}