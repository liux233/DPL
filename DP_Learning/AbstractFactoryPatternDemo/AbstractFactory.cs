using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPatternDemo
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shapeType);
        public abstract IColor GetColor(string colorType);
    }
}
