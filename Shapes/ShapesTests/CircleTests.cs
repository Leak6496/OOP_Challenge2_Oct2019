using System;
using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
   [TestFixture]
    public class CircleTests
    {
       [Test]
        [TestCase(5, 78.55)]
        [TestCase(15, 706.95)]
        [TestCase(7, 153.96)]
        public void CircleTest_GetArea_ValidInput_ReturnIsCorrect(double s, double ans)
        {
            Circle cir = new Circle("Orange", s);
            double output = Math.Round(cir.GetArea(),2);
            Assert.AreEqual(ans, output);
        }
        [TestCase(5, 31.42)]
        [TestCase(15,94.26)]
        [TestCase(7, 43.99)]
        public void CircleTest_GetPermiter_ValidInput_ReturnIsCorrect(double s, double ans)
        {
            Circle cir = new Circle("Orange", s);
            double output = Math.Round(cir.GetPerimeter(),2);
            Assert.AreEqual(ans, output);
        }
    }
}
