using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class ElectricMechanism : ActuatingMechanism
    {
        public override void ActivateMechanism()
        {
            status = true;
        }

        public override void DeactivateMechanism()
        {
            status = false;
        }

        public override bool GetStatus()
        {
            return status;
        }
    }
}