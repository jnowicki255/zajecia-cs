namespace P07_Figures.Figures
{
    public class Rectangle : Figure2D
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
                
        }

        public Rectangle(double height, double width)
        {

        }

        public override double Area()
        {
            return Height * Width;
        }

        public override double Perimeter()
        {
            return (Height * 2) + (Width * 2);
        }

        public override string GetData()
        {
            return $"Kolor: {Color}, Szerokość: {Width}, Wysokość: {Height}";
        }
    }
}
