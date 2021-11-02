using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAppBooks.Models;

namespace BlazorAppBooks.Services
{
   public interface IServicioBooks
    {
        Task<IEnumerable<Book>> GetBooks();
        Task PostBooks(Book item);
        Task<Book> GetBookItem(int BookId);
        Task PutBooks(int BookId, Book item);
        Task DeleteBooks(int BookId);
    }
}
