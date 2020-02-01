using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public abstract class ActuatingMechanism
    {
        protected bool status = false;

        public abstract void ActivateMechanism();

        public abstract bool GetStatus();

        public abstract void DeactivateMechanism();
    }
}