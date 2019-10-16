using System;
using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class RectangleTests
    {

       [Test]
        [TestCase(5,10,50)]
        [TestCase(4,6,24)]
        [TestCase(9,7,63)]
        public void Rectangle_GetArea_ValidInput_ReturnIsCorrect(double s1,double s2, double ans)
        {
            Rectangle rec = new Rectangle("Green", s1,s2);
            double output = Math.Round(rec.GetArea());
            Assert.AreEqual(ans, output);
        }

       [Test]
        [TestCase(5, 10, 30)]
        [TestCase(4, 6, 20)]
        [TestCase(9, 7, 32)]
        public void Rectangle_GetPerimeter_ValidInput_ReturnIsCorrect(double s1, double s2, double ans)
        {
            Rectangle rec = new Rectangle("Green", s1, s2);
            double output = Math.Round(rec.GetPerimeter());
            Assert.AreEqual(ans, output);
        }

    }
}
