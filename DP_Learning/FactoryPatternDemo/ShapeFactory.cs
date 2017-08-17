using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternDemo
{
    public class ShapeFactory
    {
        public static IShape GetShape(string shapeType)
        {
            if (shapeType == "")
            {
                return null;
            }
            if(shapeType.Equals("Circle"))
            {
                return new Circle();
            }
            if (shapeType.Equals("Rectangle"))
            {
                return new Rectangle();
            }
            return null;
        }
    }
}
