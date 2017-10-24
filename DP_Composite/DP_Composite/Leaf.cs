using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Composite
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void add(Component c)
        {
            Console.WriteLine("can't add to a leaf");
        }

        public override void remove(Component c)
        {
            Console.WriteLine("can't remove from a leaf");
        }

        public override void display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
