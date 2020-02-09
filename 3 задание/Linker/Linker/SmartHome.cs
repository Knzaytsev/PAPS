using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linker
{
    public class SmartHome : Component
    {

        private List<Component> children = new List<Component>();

        public void Add(Component c)
        {
            children.Add(c);
        }

        public override void Display()
        {
            foreach(var c in children)
            {
                c.Display();
            }
        }

        public void Remove(Component c)
        {
            children.Remove(c);
        }
    }
}