using P07_Figures.Figures;
using System;

namespace P07_Figures
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                var type = PrintMenu();
                GetData(type);

                if (!GetRepeatInfo())
                    break;

            }while (true);
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
                    Console.WriteLine("Podaj dane dla trójkąta...");
                    Triangle t = GetTriangleData();
                    break;

                case 2:
                    Console.WriteLine("Podaj dane dla kwadratu...");
                    break;

                case 3:
                    Console.WriteLine("Podaj dane dla prostokąta...");
                    break;

                case 4:
                    Console.WriteLine("Podaj dane dla okręgu...");
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
    }
}
