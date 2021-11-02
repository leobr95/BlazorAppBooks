using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAppBooks.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppBooks.Services
{
    public interface IServicioNegocios
    {
        Task<IEnumerable<Negocio>> GetNegocios();
        Task PostNegocios(Negocio item);
        Task<Negocio> GetNegocioItem(int NegocioId);
        Task PutNegocios(int NegocioId, Negocio item);
        Task DeleteNegocios(int NegocioId);
    }
}
