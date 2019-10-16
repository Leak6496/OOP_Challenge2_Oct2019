using System;
using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class RightAngleTests
    {
        
        [Test]
        [TestCase(5, 10,25)]
        [TestCase(4, 6,12)]
        [TestCase(9, 7,31.5)]
        public void RightAngleTest_GetArea_ValidInput_ReturnIsCorrect(double s1,double s2, double ans)
        {
            RightAngle Ria = new RightAngle("Yellow", s1,s2);
            double output = Math.Round(Ria.GetArea(),2);
            Assert.AreEqual(ans, output);
        }
        [TestCase(5, 10, 26.18)]
        [TestCase(4, 6, 17.21)]
        [TestCase(9, 7, 27.4)]
        public void RightAngleTest_GetPerimeter_ValidInput_ReturnIsCorrect(double s1, double s2, double ans)
        {
            RightAngle Ria = new RightAngle("Yellow", s1, s2);
            double output = Math.Round(Ria.GetPerimeter(), 2);
            Assert.AreEqual(ans, output);
        }
    }
}
