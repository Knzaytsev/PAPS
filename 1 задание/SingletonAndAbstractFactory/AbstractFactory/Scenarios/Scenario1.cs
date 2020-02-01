using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class Scenario1 : ScenarioGenerator
    {
        public Place CreatePlace()
        {
            return new Room();
        }

        public Sensor CreateSensor()
        {
            return new Temperature();
        }

        public Signal CreateSignal()
        {
            return new Normal();
        }
    }
}