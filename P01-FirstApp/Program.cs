using System;

namespace P01_FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserData();
            ScalarsAndRefs();
            Incrementation();
            Assignments();
        }

        private static void Assignments()
        {
            int i = 5;

            i += 6; // i = i + 6;
            Console.WriteLine($"i +=: {i}");

            i -= 7; // i = i - 7;
            Console.WriteLine($"i -=: {i}");

            i *= 10; // i = i * 10;
            Console.WriteLine($"i *=: {i}");

            i /= 2; // i = i / 2;
            Console.WriteLine($"i /=: {i}");

            i %= 2; // i = i % 2;
            Console.WriteLine($"i %=: {i}");
        }

        private static void Incrementation()
        {
            int i = 5;
            Console.WriteLine($"i: {i}");

            // Postinkrementacja
            Console.WriteLine($"i++: {i++}");
            Console.WriteLine($"i: {i}");

            // Preinkrementacja
            Console.WriteLine($"++i: {++i}");
            Console.WriteLine($"i: {i}");
        }

        private static void ScalarsAndRefs()
        {
            // 1. Typy skalarne
            int number1 = 10;
            Console.WriteLine($"1. {nameof(number1)}: {number1}");
            int number2 = number1;
            Console.WriteLine($"2. {nameof(number2)}: {number2}");
            number1 = 5;
            Console.WriteLine($"3. {nameof(number1)}: {number1}");
            Console.WriteLine($"4. {nameof(number2)}: {number2}");

            // 2. Typy referencyjne (tablice są typami referencyjnymi!)
            int[] tab1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"{nameof(tab1)}: {ConvertToString(tab1)}");

            int[] tab2 = tab1;
            Console.WriteLine($"{nameof(tab2)}: {ConvertToString(tab2)}");

            tab2[0] = 6;
            tab2[1] = 7;
            tab2[2] = 8;
            tab2[3] = 9;
            tab2[4] = 10;
            Console.WriteLine($"{nameof(tab1)}: {ConvertToString(tab1)}");
            Console.WriteLine($"{nameof(tab2)}: {ConvertToString(tab2)}");
        }

        private static string ConvertToString(int[] array)
        {
            string returnStr = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                returnStr = returnStr + $"{array[i]} ";
            }

            return returnStr;
        }



        private static void UserData()
        {
            string firstName, lastName;
            int age;

            Console.Write("Podaj swoje imie: ");
            firstName = Console.ReadLine();

            Console.Write("Podaj swoje nazwisko: ");
            lastName = Console.ReadLine();

            Console.Write("Podaj swój wiek: ");
            string strAge = Console.ReadLine();
            age = Convert.ToInt32(strAge);

            // 1. Zły sposób
            Console.Write("Nazywasz się: ");
            Console.Write(firstName);
            Console.Write(" ");
            Console.Write(lastName);
            Console.Write(" i masz ");
            Console.Write(age);
            Console.WriteLine(" lat.");

            // 2. Ciut lepszy sposób
            Console.WriteLine("Nazywasz się: " + firstName + " " + lastName + " i masz " + age + " lat.");

            // 3. Już lepiej
            Console.WriteLine("Nazywasz się: {0} {1} i masz {2} lat.", firstName, lastName, age);

            // 4. Genialnie
            Console.WriteLine($"Nazywasz się: {firstName} {lastName} i masz {age} lat.");

            // 5. Przypisanie do zmiennej
            string text = $"Nazywasz się: {firstName} {lastName} i masz {age} lat.";
            Console.WriteLine(text);
        }
    }
}
