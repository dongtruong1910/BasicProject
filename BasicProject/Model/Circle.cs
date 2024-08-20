using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject.Model
{
    internal class Circle : Shape
    {
        private double _radius;
        private Point2D _point;

                  

        public Circle() { }
        public Circle(double radius, Point2D point)
        {
            _radius = radius;
            _point = point;
        }

        public double Perimeter()
        {
            return 2*Math.PI*_radius;
        }

        public double Area()
        {
            return _radius*_radius*Math.PI;
        }

    }
}
