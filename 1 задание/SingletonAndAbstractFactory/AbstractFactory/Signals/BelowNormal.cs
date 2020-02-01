using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class BelowNormal : Signal
    {
        private float alarm = 0;

        public override void ComputeAlarm(float sensor, float volume)
        {
            alarm = sensor * volume * 0.3F;
        }

        public override bool GetAlarm()
        {
            return alarm >= 300;
        }
    }
}