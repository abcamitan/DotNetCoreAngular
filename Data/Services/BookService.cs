using System.Collections.Generic;

namespace Summaries.Data
{
    public class BookService : IBookService
    {
        public void AddBook(Book newBook)
        {
            Data.Books.Add(newBook);
        }

        public void DeleteBook(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books;
        }

        public Book GetBookById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBook(int id, Book newBook)
        {
            throw new System.NotImplementedException();
        }
    }
}