using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle: Shape, IShapeCalc
    {
        public double Radius;
        public readonly double PI;
        public Circle(string colour,double rad): base(colour)
        {
            Radius = rad;

               PI= Math.Round(Math.PI,3);
        }

       

        public double GetPerimeter()
        {
            return 2 * this.PI * this.Radius;
        }

        public double GetArea()
        {
            return this.PI * this.Radius * this.Radius;
        }
    }
}
