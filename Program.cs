using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main()
        {

            // Initialize library
            Library library = new Library();
            Book b1 = new Book();
            b1.Title = "1984";
            b1.Author = "George Orwell";
            Book b2 = new Book();
            b2.Title = "To Kill a Mockingbird";
            b2.Author = "Harper Lee";
            // Add some sample books
            library.AddBook(b1);
            library.AddBook(b2);

            // Search for a book
            List<Book> results = library.SearchBooksByTitle("1984");

            foreach (Book book in results)
            {
                Console.WriteLine($"the Title of {book} :{book.Title}");
                Console.WriteLine($"the author of {book} :{book.Author}");

            }
            // Display all books
            library.DisplayAllBooks();
        }
    }
}
