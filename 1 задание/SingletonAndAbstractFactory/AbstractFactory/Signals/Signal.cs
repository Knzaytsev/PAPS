using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class Signal
    {
        public abstract void ComputeAlarm(float sensor, float volume);
        public abstract bool GetAlarm();
    }
}