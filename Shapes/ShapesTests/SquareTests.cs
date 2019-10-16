using System;
using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class SquareTests
    {
       
       
    [Test]
        [TestCase(5,25)]
        [TestCase(15, 225)]
        [TestCase(7,49)]
        public void Square_GetArea_ValidInput_ReturnIsCorrect(double s, double ans)
        {
            Square Squ = new Square("Blue", s);
            double output = Math.Round(Squ.GetArea());
            Assert.AreEqual(ans, output);
        }
        [Test]
        [TestCase(5, 20)]
        [TestCase(15, 60)]
        [TestCase(7, 28)]
        public void Square_GetPerimeter_ValidInput_ReturnIsCorrect(double s, double ans)
        {
            Square Squ = new Square("Blue", s);
            double output = Squ.GetPerimeter();
            Assert.AreEqual(ans, output);
        }

    }
}
