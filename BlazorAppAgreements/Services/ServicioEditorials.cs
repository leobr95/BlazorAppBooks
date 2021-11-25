using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using BlazorAppBooks.Models;

namespace BlazorAppBooks.Services
{
    public class ServicioEditorials : IServicioEditorials
    {
        private readonly HttpClient httpClient;

        public ServicioEditorials(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        
        public async Task<IEnumerable<Editorial>> GetEditorials()
        {
            return await httpClient.GetJsonAsync<Editorial[]>("/api/editorials/");
        }

        public async Task PostEditorials(Editorial oEditorial)
        {
              await httpClient.PostJsonAsync<Editorial>("/api/editorials/", oEditorial);
        }

        public async Task<Editorial> GetEditorialItem(int EditorialId)
        {
            Editorial oEditorial = new Editorial();
            
            if (EditorialId != 0)
            {
                return await httpClient.GetJsonAsync<Editorial>("/api/editorials/" + EditorialId);
            }
            else
            {
                return  null;
            }
          
        }

        public async Task PutEditorials(int EditorialId, Editorial oEditorial)
        {
            await httpClient.PutJsonAsync<Editorial>("/api/editorials/"+EditorialId, oEditorial);
        }

        public async Task DeleteEditorials(int EditorialId)
        {
                 await httpClient.DeleteAsync("/api/editorials/" + EditorialId);         
        }
    }
}
