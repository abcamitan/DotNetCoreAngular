using System.Collections.Generic;
using DotNetCoreAngular.Data.Models;

namespace DotNetCoreAngular.Data.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int Id);
        Book UpdateBook(int id, Book newBook);
        void DeleteBook(int id);
        void AddBook(Book newBook);
    }
}