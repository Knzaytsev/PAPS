using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public abstract class SmartHomeBuilder
    {
        public abstract void SetSensor();

        public abstract void SetActuatingMechanism();

        public abstract void SetManagementController();

        public abstract void SetOperatorPanel();

        public abstract void SetNetworkDevice();

        public abstract void SetMultimediaSystem();

        public abstract SmartHome GetSmartHome();
    }
}