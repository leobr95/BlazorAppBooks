using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAppBooks.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppBooks.Services
{
   public interface IServicioAutors
    {
        Task<IEnumerable<Autor>> GetAutors();
        Task PostAutors(Autor item);
        Task<Autor> GetAutorItem(int AutorId);
        Task PutAutors(int AutorId, Autor item);
        Task DeleteAutors(int AutorId);
    }
}
