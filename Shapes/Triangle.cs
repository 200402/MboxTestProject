using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : IShapes
    {
        double side1;
        double side2;
        double side3;
        double square = 0;
        bool rightTriangle;

        public Triangle(string parameter)
        {
            // ПроверкаНаКорректностьВведенныхДанных()
            // Проверка на то существет ли треугольник()

            string[] parameterArray = parameter.Split(' ');
            side1 = float.Parse(parameterArray[0]);
            side2 = float.Parse(parameterArray[1]);
            side3 = float.Parse(parameterArray[2]);

            double p = (side1 + side2 + side3) / 2;

            square = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            rightTriangle = isRightTriangle(side1,side2,side3);
        }

        public Dictionary<string, string> getInfo()
        {
            Dictionary<string, string> info = new Dictionary<string, string>();
            info.Add("Площадь", $"{square}");
            if (rightTriangle)
                info.Add("Классификация", "Прямоугольный");
            else
                info.Add("Классификация", "Не прямоугольный");
            return info;
        }

        public bool isRightTriangle(double a, double b, double c)
        {
            return (a * a + b * b == c * c ||
                    c * c + b * b == a * a || 
                    a * a + c * c == b * b);
        }
    }
}
