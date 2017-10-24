using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Bridge
{
    class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA operation");
        }
    }
}
