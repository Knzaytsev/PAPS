using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linker
{
    class Program
    {
        static void Main(string[] args)
        {
            var infra = new SmartHome();
            infra.Add(new ActuatingMechanism());
            infra.Add(new MultimediaSystem());
            var home = new SmartHome();
            home.Add(infra);
            home.Display();
        }
    }
}
