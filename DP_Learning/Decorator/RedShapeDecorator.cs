using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape shape) : base(shape)
        {
        }

        public override void draw()
        {
            base.draw();
            SetRedBorder(_shape);
        }

        private void SetRedBorder(IShape shape)
        {
            Console.WriteLine("I am red");
        }
    }
}
