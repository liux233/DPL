using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCircle();
            TestRectangle();
        }


        public static void TestCircle()
        {
            IShape circle = ShapeFactory.GetShape("Circle");
            circle.draw();
        }

        public static void TestRectangle()
        {
            IShape rectangle = ShapeFactory.GetShape("Rectangle");
            rectangle.draw();
        }
    }
}
