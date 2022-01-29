using System;

namespace P08_OverridingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(5, 10);
            ComplexNumber c2 = new ComplexNumber(20, 20);

            ComplexNumber suma = c1 + c2;
            ComplexNumber roznica = c1 - c2;

            Console.WriteLine($"Suma liczb c1 i c2 to: {suma}");
            Console.WriteLine($"Różnica liczb c1 i c2 to: {roznica}");
        }
    }
}
