using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPatternDemo
{
    public class ColorFactroy : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            return null;
        }

        public  override IColor GetColor(string colorType)
        {
            if(colorType == "")
                return null;
            if(colorType.Equals("Red"))
                return (new Red());
            if(colorType.Equals("Blue"))
                return (new Blue());

            return null;
        }
    }
}
