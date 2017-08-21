﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("I am a rectangle");
        }
    }
}
