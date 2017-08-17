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
            ShapeFactory shapeFactory = new ShapeFactory(new Circle());
            shapeFactory.Draw();
        }

        public static void TestRectangle()
        {
            ShapeFactory shapeFactory = new ShapeFactory(new Rectangle());
            shapeFactory.Draw();
        }
    }
}
