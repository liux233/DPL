using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Bridge
{
    class Abstraction
    {
        protected Implementor implementor;

        public void setImplementor(Implementor imp)
        {
            this.implementor = imp;
        }

        public virtual void Operation()
        {
            this.implementor.Operation();
        }
    }
}
