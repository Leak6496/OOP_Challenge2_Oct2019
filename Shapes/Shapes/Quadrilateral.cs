using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Quadrilateral: Shape,IShapeCalc
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Side4 { get; set; }

        public Quadrilateral(string Colour, double s1, double s2, double s3, double s4) : base (Colour)
        {
        
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
            Side4 = s4;

        }

        public abstract double GetPerimeter();

        public abstract double GetArea();
       
    }
}
