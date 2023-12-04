using GeometricShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesTest._2D
{
    internal class Triangle
    {
        [TestCase(-1, 1, 1)]
        [TestCase(0, 1, 1)]
        [TestCase(10, 1, 1)]
        public void InitTriangleWithErrorTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle_2D(a, b, c));
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(4, 5, 6, 9.9215674164922145)]
        [TestCase(5, 5, 9.5, 7.4159351230980981)]
        public void TriangleGetSquareTest(double a, double b, double c, double square)
        {
            Triangle_2D triangle = new(a, b, c);
            Assert.That(triangle.GetSquare(), Is.EqualTo(square));
        }

        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        [TestCase(7, 24, 25)]
        [TestCase(9, 40, 41)]
        public void TriangleIsRightTriangleTrueTest(double a, double b, double c)
        {
            Triangle_2D triangle = new(a, b, c);
            Assert.That(triangle.IsRightTriangle(), Is.EqualTo(true));
        }

        [TestCase(4, 4, 5)]
        [TestCase(4, 12, 13)]
        [TestCase(4, 24, 25)]
        [TestCase(9, 40, 41)]
        public void TriangleIsRightTriangleFalseTest(double a, double b, double c)
        {
            Triangle_2D triangle = new(a, b, c);
            Assert.That(triangle.IsRightTriangle(), Is.EqualTo(false));
        }
    }
}
