using System;

namespace P07_Figures.Figures
{
    public class Triangle
    {
        public double Height { get; set; }
        public double BaseLength { get; set; }

        public Triangle()
        {

        }

        public Triangle(double height, double baseLength)
        {
            Height = height;
            BaseLength = baseLength;
        }

        public double Area()
        {
            return BaseLength * Height / 2;
        }

        public double Perimeter()
        {
            return 0;
        }
    }
}