using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class SmartHomeBuilder1 : SmartHomeBuilder
    {
        private SmartHome smartHome = new SmartHome();

        public override SmartHome GetSmartHome()
        {
            return smartHome;
        }

        public override void SetActuatingMechanism()
        {
            smartHome.ActuatingMechanism = new ElectricMechanism();
        }

        public override void SetManagementController()
        {
            smartHome.ManagementController = new ConcreteManagementController();
        }

        public override void SetMultimediaSystem()
        {
            smartHome.MultimediaSystem = new ConcreteMultimediaSystem();
        }

        public override void SetNetworkDevice()
        {
            smartHome.NetworkDevice = new NetworkAdapter();
        }

        public override void SetOperatorPanel()
        {
            smartHome.OperatorPanel = new ConcreteOperatorPanel();
        }

        public override void SetSensor()
        {
            smartHome.Sensor = new Illumination();
        }
    }
}