using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPatternDemo
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string factoryType)
        {
            if(factoryType == "")
                return null;
            if(factoryType.Equals("Shape"))
                return (new ShapeFactroy());
            if(factoryType.Equals("Color"))
                return (new ColorFactroy());

            return null;
        }
    }
}
