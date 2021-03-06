using System.Collections.Generic;
using System.Linq;
using DotNetCoreAngular.Data.Models;

namespace DotNetCoreAngular.Data.Services
{
    public class BookService : IBookService
    {
        public void AddBook(Book newBook)
        {
            Data.Books.Add(newBook);
        }

        public void DeleteBook(int id)
        {
            var book = Data.Books.FirstOrDefault(b => b.Id == id);
            Data.Books.Remove(book);
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books;
        }

        public Book GetBookById(int id)
        {
            return Data.Books.FirstOrDefault(b => b.Id == id);
        }

        public Book UpdateBook(int id, Book newBook)
        {
            var book = Data.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                book.Author = newBook.Author;
                book.Description = newBook.Description;
                book.Title = newBook.Title;
                book.Rate = newBook.Rate;
                book.DateStart = newBook.DateStart;
                book.DateRead = newBook.DateRead;
            }
            return book;
        }
    }
}