using System;

namespace P06_GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        private static void StartGame()
        {
            while (true)
            {
                Random random = new Random();
                int number = random.Next(0, 100);

                ReadAndCompareNumber(number);

                Console.Write("Czy chcesz spróbować jeszcze raz? [T/N]");
                string response = Console.ReadLine();

                if (response != "t")
                    break;
            }
        }

        static void ReadAndCompareNumber(int number)
        {
            Console.Write("Podaj swój typ: ");
            int value;

            do
            {
                value = Convert.ToInt32(Console.ReadLine());

                if (value < number)
                    Console.Write("Twoja liczba jest za mała, jeszcze raz: ");
                else if (value > number)
                    Console.Write("Twoja liczba jest za duża, jeszcze raz: ");
            } 
            while (value != number);

            Console.WriteLine($"Trafiłeś, wylosowana liczba to: {number}");
        }
    }
}
