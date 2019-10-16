using System;
using NUnit.Framework;
using Shapes;
namespace ShapesTests
{
    [TestFixture]
    public class Equilateral_Test
    {
       [Test]
        [TestCase(5, 10.83)]
        [TestCase(15, 97.43)]
        [TestCase(7,21.22)]
       
        public void EquilateralTest_GetArea_ValidInput_ReturnIsCorrect(double s, double ans)
        {
            Equilateral equ = new Equilateral("Black", s);
            double output = Math.Round(equ.GetArea(),2);
            Assert.AreEqual(ans, output);
        }

       [Test]
        [TestCase(5, 15)]
        [TestCase(15,45)]
        [TestCase(7, 21)]
        public void EquilateralTest_GetPerimeter_ValidInput_ReturnIsCorrect(double s, double ans)
        {
            Equilateral equi = new Equilateral("Black", s);
            double output = equi.GetPerimeter();
            Assert.AreEqual(ans, output);
        }
    }
}
