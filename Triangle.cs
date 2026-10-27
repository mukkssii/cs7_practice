using System;
using System.Collections.Generic;
using System.Text;

namespace cs7_practice
{
    internal class Triangle : IShape
    {
        double a { get; set; }
        double b { get; set; }
        double c { get; set; }
        public double CalculateArea()
        {
            return a * b / 2;
        }

        public double CalculatePerimeter()
        {
            return a + b + c;
        }
    }
}
