namespace P07_Figures.Figures
{
    public class Square : Figure2D
    {
        public double SideLength { get; set; }

        public override double Area()
        {
            return SideLength * SideLength;
        }

        public double Perimeter()
        {
            return SideLength * 4;
        }

        public override string GetData()
        {
            return $"Kolor: {Color}, Długość boku: {SideLength}";
        }
    }
}
