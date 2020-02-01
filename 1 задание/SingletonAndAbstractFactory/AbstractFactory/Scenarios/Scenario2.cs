using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Scenarios
{
    class Scenario2 : ScenarioGenerator
    {
        public Place CreatePlace()
        {
            return new Garage();
        }

        public Sensor CreateSensor()
        {
            return new Illumination();
        }

        public Signal CreateSignal()
        {
            return new AboveNormal();
        }
    }
}
