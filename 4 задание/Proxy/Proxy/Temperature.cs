using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Temperature : Sensor
    {
        private Dictionary<string, float> db = new Dictionary<string, float>();
        public override void AddMeasure(string date, float measure)
        {
            db.Add(date, measure);
        }

        public override float GetMeasure(string date)
        {
            if (db.ContainsKey(date))
                return db[date];
            return -200;
        }

        public override Dictionary<string, float> GetMeasurements()
        {
            return db;
        }

        public override Dictionary<string, float> GetMeasurements(string dateFrom, string dateTo)
        {
            Dictionary<string, float> temp = new Dictionary<string, float>();
            foreach (var d in db)
            {
                if (string.Compare(d.Key, dateFrom) <= 0 && string.Compare(d.Key, dateTo) >= 0)
                    temp.Add(d.Key, d.Value);
            }
            if (temp.Count == 0)
                return null;
            return temp;
        }
    }
}
