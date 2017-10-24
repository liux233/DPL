using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Bridge
{
    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
