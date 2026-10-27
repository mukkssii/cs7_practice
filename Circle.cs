using System;
using System.Collections.Generic;
using System.Text;

namespace cs7_practice
{
    internal class Circle : IShape
    { 
        double _r { get; set; }
        public Circle(double r)
        {
            _r = r;
        }
        public double CalculateArea()
        {
            return 3.14 * _r * _r;
        }

        public double CalculatePerimeter()
        {
            return 6.28 * _r;
        }
    }
}
