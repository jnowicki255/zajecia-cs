using System;

namespace P07_Figures.Figures
{
    public class Triangle : Figure2D
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

        public override double Area()
        {
            return BaseLength * Height / 2;
        }

        public double Perimeter()
        {
            return 0;
        }

        public override string GetData()
        {
            return $"Kolor: {Color}, Wysokość: {Height}, Długość podstawy: {BaseLength}";
        }
    }
}