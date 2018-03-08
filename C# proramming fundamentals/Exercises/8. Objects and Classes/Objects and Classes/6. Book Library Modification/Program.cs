using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _6.Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> myBooks = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                Book book = new Book();
                book.Title = command[0];
                book.Author = command[1];
                book.Publisher = command[2];
                book.ReleaseDate = DateTime.ParseExact(command[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBN = command[4];
                book.Price = double.Parse(command[5]);

                myBooks.Add(book);
            }

            DateTime finalDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Library myLibrary = new Library();
            myLibrary.Books = myBooks;

            foreach (var book in myLibrary.Books.Where(x=> x.ReleaseDate>finalDate).OrderBy(x => x.ReleaseDate).ThenBy(x =>x.Title))
            {
                Console.WriteLine("{0} -> {1}", book.Title, book.ReleaseDate.ToString("dd.MM.yyyy"));
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

}