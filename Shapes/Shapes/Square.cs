using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square: Quadrilateral
    {
       

        public Square(string colour, double s) : base (colour, s, s, s, s)
        {
        }
     
        public override double GetPerimeter()
        {
            
            return 4 * this.Side1;
        }
        public override double GetArea()
        {

            return this.Side1 * this.Side1;
        }
    }
}
