using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius, string color) : base(color)
        {
            Radius = radius;
        }
        public override double Area() => Math.PI * Radius * Radius;

    }
}
