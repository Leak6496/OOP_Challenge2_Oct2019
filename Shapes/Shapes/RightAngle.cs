using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class RightAngle:Triangle,IShapeCalc
    {
       
     
        public RightAngle (string colour,double s1,double s2): base(colour, s1, s2, (double)Math.Sqrt(s1 * s1 + s2 * s2))
        {
            
        }
        public void SetHypothenuse()
        {
            double sideh;
           sideh = this.Side3;
        }
        public double GetArea()
        {
            return ((this.Side1*this.Side2)/2);
        }
             

        public double GetPerimeter()
        {
            return this.Side1 + this.Side2 + this.Side3;
        }
    }
    
}
