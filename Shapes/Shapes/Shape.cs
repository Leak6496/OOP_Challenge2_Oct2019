﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public string Colour { get; set; }
        public Shape(string pC)
        {
            Colour = pC;
        }

        public void Operation1()
        {
            throw new NotImplementedException();
        }
    }
}
