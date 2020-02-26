using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    abstract class Sensor
    {
        public abstract void AddMeasure(string date, float measure);
        public abstract Dictionary<string, float> GetMeasurements();
        public abstract float GetMeasure(string date);
        public abstract Dictionary<string, float> GetMeasurements(string dateFrom, string dateTo);
    }
}
