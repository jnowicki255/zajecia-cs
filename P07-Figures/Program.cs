using P07_Figures.Figures;
using System;

namespace P07_Figures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle(20.5);
            Circle c3 = new Circle(10.5, "Red");

            Rectangle r1 = new Rectangle()
            {
                Color = "Pink",
                Width = 20,
                Height = 40,
            };

            Triangle t1 = new Triangle()
            {
                Color = "Blue",
                BaseLength = 20,
                Height = 100
            };

            Square s1 = new Square()
            {
                Color = "Brown",
                SideLength = 50
            };

            Figure2D[] fArr = new Figure2D[] { c3, r1, t1, s1 };
            foreach(var f in fArr)
            {
                Console.WriteLine(f.GetData());
                Console.WriteLine($"Pole figury to: {f.Area()}");
            }

            //do
            //{
            //    Console.Clear();

            //    var type = PrintMenu();
            //    GetData(type);

            //    if (!GetRepeatInfo())
            //        break;

            //}while (true);
        }

        private static int PrintMenu()
        {
            Console.WriteLine("Dla jakiej figury chcesz obliczyć dane?");
            Console.WriteLine("[1] Trójkąt");
            Console.WriteLine("[2] Kwadrat");
            Console.WriteLine("[3] Prostokąt");
            Console.WriteLine("[4] Okrąg");

            var ans = Console.ReadKey();
            switch (ans.Key)
            {
                case ConsoleKey.D1:
                    return 1;

                case ConsoleKey.D2:
                    return 2;

                case ConsoleKey.D3:
                    return 3;

                case ConsoleKey.D4:
                    return 4;

                default:
                    Console.Clear();
                    return PrintMenu();

            }
        }

        private static void GetData(int type)
        {
            switch (type)
            {
                case 1:
                    Triangle tri = GetTriangleData();
                    Console.WriteLine($"Pole podanego trójkąta to: {tri.Area()}");
                    Console.WriteLine($"Obwód podanego trójkąta to: {tri.Perimeter()}");
                    break;

                case 2:
                    Square sq = GetSquareData();
                    Console.WriteLine($"Pole podanego kwadratu to: {sq.Area()}");
                    Console.WriteLine($"Obwód podanego kwadratu to: {sq.Perimeter()}");
                    break;

                case 3:
                    Rectangle rect = GetRectangleData();
                    Console.WriteLine($"Pole podanego prostokąta to: {rect.Area()}");
                    Console.WriteLine($"Obwód podanego prostokąta to: {rect.Perimeter()}");
                    break;

                case 4:
                    Circle cir = GetCircleData();
                    Console.WriteLine($"Pole podanego okręgu to: {cir.Area()}");
                    Console.WriteLine($"Obwód podanego okręgu to: {cir.Perimeter()}");
                    break;
            }
        }

        private static bool GetRepeatInfo()
        {
            Console.WriteLine("Czy chesz obliczyć dane dla innej figury? [T/N]");
            var ans = Console.ReadKey();

            if (ans.Key == ConsoleKey.T || ans.Key == ConsoleKey.Y)
                return true;
            return false;
        }

        private static Triangle GetTriangleData()
        {
            Console.Write("Podaj wysokość trójkąta: ");
            var height = Console.ReadLine();

            Console.Write("Podaj długość podstawy trójkąta: ");
            var baseLength = Console.ReadLine();

            return new Triangle(Convert.ToDouble(height), Convert.ToDouble(baseLength));
        }

        private static Rectangle GetRectangleData()
        {
            Console.Write("Podaj szerokość prostokąta: ");
            var width = Console.ReadLine();

            Console.Write("Podaj wysokość prostokąta: ");
            var height = Console.ReadLine();

            return new Rectangle
            {
                Height = Convert.ToDouble(height),
                Width = Convert.ToDouble(width)
            };
        }

        private static Square GetSquareData()
        {
            Console.Write("Podaj długość boku kwadratu: ");
            var length = Console.ReadLine();

            return new Square
            {
                SideLength = Convert.ToDouble(length)
            };
        }

        private static Circle GetCircleData()
        {
            Console.Write("Podaj promień okręgu: ");
            var radius = Console.ReadLine();

            return new Circle
            {
                Radius = Convert.ToDouble(radius)
            };
        }
    }
}
