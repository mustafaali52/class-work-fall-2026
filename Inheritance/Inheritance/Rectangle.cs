using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // base(...) calls the parent constructor
        public Rectangle(double width, double height, string color) : base(color)
        {
            Width = width;
            Height = height;
        }

        // override replaces the parent's implementation
        public override double Area() => Width * Height;
    }
}
