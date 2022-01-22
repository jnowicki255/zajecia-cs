using System;

namespace P02_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Objects!");

            Book firstBook = new Book("Informatyka w szkole średniej.",
                "Jan Nowak", 400);
        }
    }

    public class Book
    {
        public string Title;
        public string Author;
        public int PagesCount;

        public Book(string title, string author, int pagesCount)
        {
            Title = title;
            Author = author;
            PagesCount = pagesCount;
        }
    }
}
