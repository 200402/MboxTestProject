using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesTest._2D
{
    internal class CompileTimeTest
    {
        [Test]
        public void Calculating_the_area_of_a_shape_without_knowing_the_type()
        {
            IShapes_2D shape = new Circle_2D(1);
            Assert.That(shape.GetSquare(), Is.EqualTo(3.1415926535897931));

            shape = new Triangle_2D(3,4,5);
            Assert.That(shape.GetSquare(), Is.EqualTo(6));
        }
    }
}
