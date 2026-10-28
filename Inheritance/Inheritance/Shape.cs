using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Shape
    {
        public string Color { get; set; }
        public Shape(string color)
        {
            Color = color;
        }
        // virtual = can be overridden by derived classes
        public virtual double Area()
        {
            return 0;
        }
        public virtual string Describe()
            => $"A {Color} shape with area {Area():F2}";

    }
}
