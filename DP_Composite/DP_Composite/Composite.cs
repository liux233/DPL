using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Composite
{
    class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void add(Component c)
        {
            children.Add(c);
        }

        public override void remove(Component c)
        {
            children.Remove(c);
        }

        public override void display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component c in children)
            {
                c.display(depth + 2);
            }
        }
    }
}
