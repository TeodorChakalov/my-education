using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _5.Book_Library
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

            Library myLibrary = new Library();
            myLibrary.Books = myBooks;

            foreach (var book in myLibrary.Books.GroupBy(x => x.Author).OrderByDescending(x => x.Sum(y => y.Price)).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:F2}", book.Key, book.Sum(x => x.Price));
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