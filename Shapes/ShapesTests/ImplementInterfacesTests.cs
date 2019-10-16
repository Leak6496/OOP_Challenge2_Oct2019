using System;
using NUnit.Framework;
using Shapes;

namespace ShapesTests
{
    [TestFixture]
    public class ImplementInterfacesTests
    {
        [Test]
        public void ImplementsTestsSquare_IShapeCalc()
        {
            Square s = new Square("red", 5);
            Assert.IsTrue(s is IShapeCalc);

        }



        [Test]
        public void ImplementsTestsRectangle_IShapeCalc()
        {
            Rectangle s = new Rectangle("purple", 5, 3);
            Assert.IsTrue(s is IShapeCalc);

        }

        [Test]
        public void ImplementsTestsEquilateral_IShapeCalc()
        {
            Equilateral s = new Equilateral("purple", 5);
            Assert.IsTrue(s is IShapeCalc);

        }

        [Test]
    public void ImplementsTestsRightAngle_IShapeCalc()
    {
        RightAngle s = new RightAngle("blue", 5, 10);
        Assert.IsTrue(s is IShapeCalc);

    }

    [Test]
    public void ImplementsTestsCircle_IShapeCalc()
    {
        Circle s = new Circle("purple", 5);
        Assert.IsTrue(s is IShapeCalc);

    }
}  
}
