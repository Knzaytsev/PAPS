using AbstractFactory.Scenarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ScenarioClient client = new ScenarioClient(new Scenario1());
            client.ComputeVolumePlace();
            client.SetSensorValue(60);
            Console.WriteLine(client.ComputeSignal());

            client = new ScenarioClient(new Scenario2());
            client.ComputeVolumePlace();
            client.SetSensorValue(3);
            Console.WriteLine(client.ComputeSignal());
        }
    }
}
