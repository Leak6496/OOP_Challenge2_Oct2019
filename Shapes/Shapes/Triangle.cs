using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Triangle: Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(string colour, double s1, double s2, double s3) : base (colour)
        {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;

        }

      
    }
}
