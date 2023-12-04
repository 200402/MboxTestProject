using GeometricShapes._2D.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes._2D
{
    public class Circle_2D : IСircle_2D
    {
        public Circle_2D(double Radius)
        {
            if (Radius <= 0)
                throw new ArgumentException("Радиус круга не может быть равен или меньше нуля.");

            this.Radius = Radius;
        }

        private double _Radius;
        public double Radius { get => _Radius; set => _Radius = value; }

        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
