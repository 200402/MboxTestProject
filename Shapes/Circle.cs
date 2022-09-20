using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : IShapes
    {
        double radius;
        double square = 0;

        public Circle(string parameter)
        {
            // ПроверкаНаКорректностьВведенныхДанных()
            radius = float.Parse(parameter);
            square = radius*radius*Math.PI;
        }

        public Dictionary<string, string> getInfo()
        {
            Dictionary<string, string> info = new Dictionary<string, string>();
            info.Add("Площадь", $"{square}");
            return info;
        }
    }
}
