using System;
namespace LibraryManagementSystem
{
    class Library
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book b)
        {
            books.Add(b);
        }
        private List<Book> myList = new List<Book>();

        public List<Book> SearchBooksByTitle(string s)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books found with that title.");
            }
            else
            {
                foreach (Book book in books)
                {
                    if (book.Title.Contains(s))
                    {
                        myList.Add(book);
                    }
                }
            }
            return myList;

        }
        public void DisplayAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"the Title of {book} :{book.Title}");
                Console.WriteLine($"the author of {book} :{book.Author}");
            }
        }
    }
}
