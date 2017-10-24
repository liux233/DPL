﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            ab.setImplementor(new ConcreteImplementorA());
            ab.Operation();

            ab.setImplementor(new ConcreteImplementorB());
            ab.Operation();
        }
    }
}
