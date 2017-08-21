using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        public static void TestCircle()
        {
            IShape circle = new Circle();
            IShape redCircle = new RedShapeDecorator(circle);
            Console.WriteLine("normal circle:");
            circle.draw();
            Console.WriteLine("\nred circle:");
            redCircle.draw();
        }

        public static void TestRectangle()
        {
            IShape rectangle = new Rectangle();
            IShape redRectangle = new RedShapeDecorator(rectangle);
            Console.WriteLine("\nnormal rectangle:");
            rectangle.draw();
            Console.WriteLine("\nred rectangle:");
            redRectangle.draw();
        }

        static void Main(string[] args)
        {
            TestCircle();
            TestRectangle();
        }
    }
}
