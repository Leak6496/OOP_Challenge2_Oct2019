using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesException
{
    public class LessthanoneException : Exception

    {

        public LessthanoneException(string message) : base(message) { }

    }

    public class InvalidDecimalInput : Exception

    {

        public InvalidDecimalInput(string message) : base(message) { }
        public InvalidDecimalInput() : base() { }

    }
}
