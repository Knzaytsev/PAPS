using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Proxy : Sensor
    {
        private Temperature realSensor = new Temperature();
        private Dictionary<string, float> measurements = new Dictionary<string, float>();
        private int count = 10;

        public override void AddMeasure(string date, float measure)
        {
            if (count <= 0)
            {
                foreach(var r in measurements)
                {
                    realSensor.AddMeasure(r.Key, r.Value);
                }
                measurements = new Dictionary<string, float>();
                count = 11;
            }
            measurements[date] = measure;
            count--;
        }

        public override float GetMeasure(string date)
        {
            if (measurements.ContainsKey(date))
                return measurements[date];
            return realSensor.GetMeasure(date);
        }

        public Dictionary<string, float> GetCurrentMeasurements()
        {
            return measurements;
        }

        public override Dictionary<string, float> GetMeasurements()
        {
            return realSensor.GetMeasurements();
        }

        public override Dictionary<string, float> GetMeasurements(string dateFrom, string dateTo)
        {
            Dictionary<string, float> temp = new Dictionary<string, float>();
            foreach (var d in measurements)
            {
                if (string.Compare(d.Key, dateFrom) <= 0 && string.Compare(d.Key, dateTo) >= 0)
                    temp.Add(d.Key, d.Value);
            }
            if (temp.Count != 0)
                return temp;
            return realSensor.GetMeasurements(dateFrom, dateTo);
        }
    }
}
