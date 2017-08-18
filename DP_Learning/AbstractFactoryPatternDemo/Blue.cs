using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPatternDemo
{
    public class Blue : IColor
    {
        public void fill()
        {
            Console.WriteLine("I am blue");
        }
    }
}
