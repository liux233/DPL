using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Composite
{
    abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void add(Component c);
        public abstract void remove(Component c);
        public abstract void display(int depth);
    }
}
