using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesTest._2D
{
    internal class Circle
    {
        [TestCase(-1)]
        [TestCase(-2)]
        [TestCase(0)]
        public void InitCircleWithErrorTest(double a)
        {
            Assert.Catch<ArgumentException>(() => new Circle_2D(a));
        }

        [TestCase(1, 3.1415926535897931)]
        [TestCase(2, 12.566370614359172)]
        [TestCase(3, 28.274333882308138)]
        public void CircleGetSquareTest(double a, double s)
        {
            Circle_2D сircle = new(a);
            Assert.That(сircle.GetSquare(), Is.EqualTo(s));
        }
    }
}
