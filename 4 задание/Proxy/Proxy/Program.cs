using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Sensor sensor = new Proxy();
            for(int i = 0; i < 11; ++i)
            {
                sensor.AddMeasure("0:0:" + i, rnd.Next(-20, 20));
            }
            var measurements = sensor.GetMeasurements();
        }
    }
}
