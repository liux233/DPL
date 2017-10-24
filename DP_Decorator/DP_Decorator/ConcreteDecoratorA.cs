using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Decorator
{
    class ConcreteDecoratorA :Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "new State";
            Console.WriteLine("concrete derorator A op");
        }
    }
}
