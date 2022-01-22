using System;

namespace P04_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Utworzenie obiektów typu Person
            Person person1 = new Person()
            {
                FirstName = "Jacek",
                LastName = "Nowicki",
                Age = 27,
                Telephone = "666-666-666"
            };

            Person person2 = new Person()
            {
                FirstName = "John",
                LastName = "Wick",
                Age = 42,
                Telephone = "555-555-555"
            };

            // 2. Wyświetlenie danych o obiektach
            person1.PrintData();
            person2.PrintData();

            // 3. Wykorzystanie zmiennej statycznej\
            Console.WriteLine($"Imię osoby: {person1.FirstName}"); // Aby użyć pola NIE-statycznego musimy mieć utworzony obiekt.
            Console.WriteLine($"Każda osoba posiada {Person.NumberOfLegs}"); // Do wykorzyania pola statycznego nie jest potrzebne stworzenie obiektu.

            person1.PrintData();
            Person.Move(100);

            // 4. Realne zastosowania

            //Math mathObj = new Math();
            //double cos = mathObj.Cos(x);

            double x = 2;
            double y = Math.Pow(x, 2);
            double sin = Math.Sin(x);
        }
    }

    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Telephone;

        public static int NumberOfLegs = 2;

        public void PrintData()
        {
            Console.WriteLine($"FirstName: {FirstName}; LastName: {LastName}, Age: {Age}," +
                $" Telephone: {Telephone}; NumberOfLegs: {NumberOfLegs}");
        }

        public static void Move(int distance)
        {
            Console.WriteLine($"Person with {NumberOfLegs} legs has moved {distance} meters");
        }
    }
}
