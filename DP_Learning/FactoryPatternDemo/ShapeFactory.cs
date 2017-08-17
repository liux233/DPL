using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatternDemo
{
    public class ShapeFactory
    {
        private IShape _shape;
        public ShapeFactory(IShape shape)
        {
            this._shape = shape;
        }

        public void Draw()
        {
            this._shape.draw();
        }
    }
}
