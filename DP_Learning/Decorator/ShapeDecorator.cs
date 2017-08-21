using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape _shape;
        public ShapeDecorator(IShape shape)
        {
            this._shape = shape;
        }

        public virtual void draw()
        {
            this._shape.draw();
        }
    }
}
