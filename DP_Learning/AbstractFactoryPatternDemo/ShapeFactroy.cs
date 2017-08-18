using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPatternDemo
{
    public class ShapeFactroy : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            if (shapeType == "")
                return null;
            if (shapeType.Equals("Circle"))
                return (new Circle());
            if (shapeType.Equals("Rectangle"))
                return (new Rectangle());

            return null;
        }

        public override IColor GetColor(string colorType)
        {
            return null;
        }
    }
}
