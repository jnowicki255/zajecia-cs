using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Figures.Figures
{
    public abstract class Figure2D
    {
        public string Color { get; set; }

        protected Figure2D()
        {

        }

        protected Figure2D(string color)
        {
            Color = color;
        }

        public virtual string GetData()
        {
            return $"Kolor: {Color}";
        }

        public abstract double Area();

        public abstract double Perimeter();
    }
}
