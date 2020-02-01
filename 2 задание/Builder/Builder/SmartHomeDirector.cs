using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class SmartHomeDirector
    {

        public SmartHomeDirector(SmartHomeBuilder smartHomeBuilder)
        {
            this.smartHomeBuilder = smartHomeBuilder;
        }

        private SmartHomeBuilder smartHomeBuilder;

        public void Construct()
        {
            smartHomeBuilder.SetActuatingMechanism();
            smartHomeBuilder.SetManagementController();
            smartHomeBuilder.SetMultimediaSystem();
            smartHomeBuilder.SetNetworkDevice();
            smartHomeBuilder.SetOperatorPanel();
            smartHomeBuilder.SetSensor();
        }
    }
}