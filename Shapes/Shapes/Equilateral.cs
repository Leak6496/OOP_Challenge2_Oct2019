using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Equilateral: Triangle, IShapeCalc
    {
        public Equilateral(string colour, double s1) : base(colour, s1, s1, s1)
        { }
       

        public double GetArea()
        {
            return (double)Math.Sqrt(3) / 4 * (this.Side1*this.Side1);
            
        }

        public double GetPerimeter()
        {
            return 3 * this.Side1;
        }
    }
}
