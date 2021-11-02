using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using BlazorAppBooks.Models;

namespace BlazorAppBooks.Services
{
    public class ServicioBooks : IServicioBooks
    {
        private readonly HttpClient httpClient;

        public ServicioBooks(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await httpClient.GetJsonAsync<Book[]>("/api/books/");
        }
        public async Task PostBooks(Book oBook)
        {
            await httpClient.PostJsonAsync<Book>("/api/books/", oBook);
        }

        public async Task<Book> GetBookItem(int BookId)
        {
            Book oBook = new Book();

            if (BookId != 0)
            {
                return await httpClient.GetJsonAsync<Book>("/api/books/" + BookId);
            }
            else
            {
                return null;
            }

        }

        public async Task PutBooks(int BookId, Book oBook)
        {
            await httpClient.PutJsonAsync<Book>("/api/books/" + BookId, oBook);
        }

        public async Task DeleteBooks(int BookId)
        {
            await httpClient.DeleteAsync("/api/books/" + BookId);
        }

    }
}
