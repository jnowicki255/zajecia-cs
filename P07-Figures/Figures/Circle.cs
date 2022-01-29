using System;

namespace P07_Figures.Figures
{
    public class Circle : Figure2D
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle(double radius, string color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string GetData()
        {
            return $"Kolor: {Color}, Promień: {Radius}";
        }
    }
}
