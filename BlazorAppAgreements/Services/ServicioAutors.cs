using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using BlazorAppBooks.Models;

namespace BlazorAppBooks.Services
{
    public class ServicioAutors : IServicioAutors
    {
        private readonly HttpClient httpClient;

        public ServicioAutors(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        
        public async Task<IEnumerable<Autor>> GetAutors()
        {
            return await httpClient.GetJsonAsync<Autor[]>("/api/autors/");
        }

        public async Task PostAutors(Autor oAutor)
        {
              await httpClient.PostJsonAsync<Autor>("/api/autors/", oAutor);
        }

        public async Task<Autor> GetAutorItem(int AutorId)
        {
            Autor oAutor = new Autor();
            
            if (AutorId != 0)
            {
                return await httpClient.GetJsonAsync<Autor>("/api/autors/" + AutorId);
            }
            else
            {
                return  null;
            }
          
        }

        public async Task PutAutors(int AutorId, Autor oAutor)
        {
            await httpClient.PutJsonAsync<Autor>("/api/autors/"+AutorId, oAutor);
        }

        public async Task DeleteAutors(int AutorId)
        {
                 await httpClient.DeleteAsync("/api/autors/" + AutorId);         
        }
    }
}
