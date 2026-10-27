using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace cs7_practice
{
    internal class Rectangle : IShape
    {
        double a {  get; set; }
        double b { get; set; }
        public double CalculateArea()
        {
            return a * b;
        }

        public double CalculatePerimeter()
        {
            return (a + b) * 2;
        }
    }
}
