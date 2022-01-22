using System;

namespace P02_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book firstBook = new Book("Informatyka w szkole średniej.", "Jan Nowak", 400);
            Book secondBook = new Book("Krzyżacy", "Sienkiewicz", 1000);
            Book thirdBook = new Book(secondBook);
            Book fourthBook = new Book();

            firstBook.Print();
            secondBook.Print("secondBook"); // Wywołanie przeciążonej metody
            thirdBook.Print();
            fourthBook.Print();
        }
    }

    public class Book
    {
        public string Title;
        public string Author;
        public int PagesCount;

        public Book()
        {
            Title = string.Empty;
            Author = string.Empty;
            PagesCount = 0;
        }

        /// <summary>
        /// Konstruktor standardowy
        /// </summary>
        /// <param name="title">Tytuł książki</param>
        /// <param name="author">Autor książki</param>
        /// <param name="pagesCount">Liczba stron</param>
        public Book(string title, string author, int pagesCount)
        {
            this.Title = title;
            this.Author = author;
            this.PagesCount = pagesCount;
        }

        /// <summary>
        /// Konstruktor kopiujący
        /// </summary>
        /// <param name="book"></param>
        public Book(Book book)
        {
            Title = book.Title;
            Author = book.Author;
            PagesCount = book.PagesCount;
        }

        public void Print()
        {
            if (Title == string.Empty)
                return;

            Console.WriteLine($"Tytuł książki: {Title}, Autor: {Author}, Ilość stron: {PagesCount}");
        }

        public void Print(string bookName) // Przeciążenie metody Print()
        {
            Console.WriteLine($"Książka: {bookName}, Tytuł książki: {Title}, Autor: {Author}, Ilość stron: {PagesCount}");
        }
    }
}
