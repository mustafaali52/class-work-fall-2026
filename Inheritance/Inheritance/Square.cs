using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Square : Rectangle
    {
        public Square(double side, string color) 
            : base(side, side, color)
        {
        }
        
        public override string Describe()
        {
            // Call parent Describe() and add extra info
            //return base.Describe() + $" [Square, side {Width}]";
            return $" [Square, side {Width}]";
        }

    }
}
