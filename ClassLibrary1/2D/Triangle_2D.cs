using GeometricShapes._2D.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes._2D
{
    public class Triangle_2D : ITriangle_2D
    {
        private double _SideA;
        private double _SideB;
        private double _SideC;
        public double SideA { get => _SideA; set => _SideA = value; }
        public double SideB { get => _SideB; set => _SideB = value; }
        public double SideC { get => _SideC; set => _SideC = value; }

        public Triangle_2D(double SideA, double SideB, double SideC)
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                throw new ArgumentException("Сторона треугольника не может быть равна или меньше нуля.");

            var largest_side = Math.Max(SideA, Math.Max(SideB, SideC));
            var perimeter = SideA + SideB + SideC;
            if (perimeter - largest_side * 2 < 0)
                throw new ArgumentException("Наибольшая сторона треугольника должна быть меньше суммы других сторон.");

            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
        }

        public double GetSquare()
        {
            var halfPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }

        public bool IsRightTriangle()
        {
            var a = SideA;
            var b = SideB;
            var c = SideC;
            return ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a));
        }
    }
}
