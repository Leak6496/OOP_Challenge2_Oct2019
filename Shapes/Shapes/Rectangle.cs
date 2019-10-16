using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle: Quadrilateral
    {
        public Rectangle(string colour, double Length, double Width) : base(colour, Length, Width, Length, Width)
        {

        }

        public override double GetPerimeter()
        {

            return 2*(this.Side1 + this.Side2);
        }
        public override double GetArea()
        {
            return this.Side1*this.Side2;

        }
      
    }
}
