using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");

            root.add(new Leaf("leaf a"));
            root.add(new Leaf("leaf b"));

            Composite comp = new Composite("Composite x");
            comp.add(new Leaf("leaf xa"));
            comp.add(new Leaf("leaf xb"));

            root.add(comp);

            Composite comp2 = new Composite("composite xy");
            comp2.add(new Leaf("leaf xya"));
            comp2.add(new Leaf("leaf xyb"));

            comp.add(comp2);

            root.display(1);
        }
    }
}
