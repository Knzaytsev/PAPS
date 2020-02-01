using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class ScenarioClient
    {
        private Place place;
        private Sensor sensor;
        private Signal signal;

        public ScenarioClient(ScenarioGenerator generator)
        {
            place = generator.CreatePlace();
            sensor = generator.CreateSensor();
            signal = generator.CreateSignal();
        }

        public void ComputeVolumePlace()
        {
            place.ComputeVolume();
        }

        public void SetSensorValue(float val)
        {
            sensor.SetSensorValue(val);
        }

        public bool ComputeSignal()
        {
            signal.ComputeAlarm(sensor.GetSensorValue(), place.GetVolume());
            return signal.GetAlarm();
        }
    }
}