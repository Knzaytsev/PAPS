using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public interface ScenarioGenerator
    {
        Sensor CreateSensor();
        Place CreatePlace();
        Signal CreateSignal();
    }
}