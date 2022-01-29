namespace P07_Figures.Figures
{
    public class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return (Height * 2) + (Width * 2);
        }
    }
}
