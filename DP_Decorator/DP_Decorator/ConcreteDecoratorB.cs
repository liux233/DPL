using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Decorator
{
    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddBehavior();
            Console.WriteLine("concrete decorator b op");
        }

        private void AddBehavior()
        {

        }
    }
}
