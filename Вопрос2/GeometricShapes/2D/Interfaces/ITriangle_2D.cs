using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes._2D.Interfaces
{
    public interface ITriangle_2D : IShapes_2D
    {
        public bool IsRightTriangle();

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
    }
}
