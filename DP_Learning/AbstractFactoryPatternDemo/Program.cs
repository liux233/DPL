using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("Shape");
            
            IShape circle = shapeFactory.GetShape("Circle");
            circle.draw();

            IShape rectangle = shapeFactory.GetShape("Rectangle");
            rectangle.draw();

            AbstractFactory colorFactory = FactoryProducer.GetFactory("Color");

            IColor red = colorFactory.GetColor("Red");
            red.fill();

            IColor blue = colorFactory.GetColor("Blue");
            blue.fill();
        }
    }
}
