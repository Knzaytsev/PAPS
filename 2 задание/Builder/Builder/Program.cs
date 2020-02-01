using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartHomeBuilder builder = new SmartHomeBuilder1();
            SmartHomeDirector director = new SmartHomeDirector(builder);
            director.Construct();
            SmartHome smartHome = builder.GetSmartHome();
        }
    }
}
