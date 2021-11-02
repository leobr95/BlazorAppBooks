using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using BlazorAppBooks.Models;

namespace BlazorAppBooks.Services
{
    public class ServicioNegocios : IServicioNegocios
    {
        private readonly HttpClient httpClient;

        public ServicioNegocios(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Negocio>> GetNegocios()
        {
            return await httpClient.GetJsonAsync<Negocio[]>("/api/negocios/");
        }

        public async Task PostNegocios(Negocio oNegocio)
        {
            await httpClient.PostJsonAsync<Negocio>("/api/negocios/", oNegocio);
        }

        public async Task<Negocio> GetNegocioItem(int NegocioId)
        {
            Negocio oNegocio = new Negocio();

            if (NegocioId != 0)
            {
                return await httpClient.GetJsonAsync<Negocio>("/api/negocios/" + NegocioId);
            }
            else
            {
                return null;
            }

        }

        public async Task PutNegocios(int NegocioId, Negocio oNegocio)
        {
            await httpClient.PutJsonAsync<Negocio>("/api/negocios/" + NegocioId, oNegocio);
        }

        public async Task DeleteNegocios(int NegocioId)
        {
            await httpClient.DeleteAsync("/api/negocios/" + NegocioId);
        }
    }
}
