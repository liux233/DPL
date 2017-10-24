using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Decorator
{
    class Decorator:Component
    {
        protected Component c;
        public void setComponent(Component c)
        {
            this.c = c;
        }
        public override void Operation()
        {
            if (c != null)
            {
                c.Operation();
            }
        }
    }
}
