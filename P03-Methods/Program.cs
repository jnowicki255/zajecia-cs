using System;
using System.Text;

namespace P03_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Przekazanie argumentu przez wartość.
            string name1 = "JACEK";
            StringOperation(name1);
            Console.WriteLine(name1);

            // 2. Przekazanie argumentu przez referencję
            string name2 = "JACEK";
            StringOperationRef(ref name2);
            Console.WriteLine(name2); // W przypadku refencji zmieniona zostaje wartość źródłowa.

            // 3. Przekzanie argumentu przez wyjście
            string name3;
            StringOperationOut(out name3);
            Console.WriteLine(name3);

            // 4. Przekazywanie listy argumentów
            StringOperationParams("Paweł");
            StringOperationParams("Jacek", "Adam", "Piotr");
            StringOperationParams("Marek", "Maciej", "Ryszard", "Zdzisław", "Mieczysław");
        }

        static void StringOperation(string str)
        {
            str = str.ToLower();
            Console.WriteLine(str);
        }

        static void StringOperationRef(ref string str)
        {
            str = str.ToLower();
            Console.WriteLine(str);
        }

        static void StringOperationOut(out string str)
        {
            str = "Krzysztof";
        }

        static void StringOperationParams(params string[] strArray)
        {
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < strArray.Length; i++)
            {
                strBuilder.Append(" ");
                strBuilder.Append(strArray[i]);
                strBuilder.Append(" ");
            }
            
            Console.WriteLine(strBuilder.ToString());
        }
    }
}
