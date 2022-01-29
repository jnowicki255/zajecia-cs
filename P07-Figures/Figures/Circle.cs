using System;

namespace P07_Figures.Figures
{
    public class Circle
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
