using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAppBooks.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppBooks.Services
{
   public interface IServicioEditorials
    {
        Task<IEnumerable<Editorial>> GetEditorials();
        Task PostEditorials(Editorial item);
        Task<Editorial> GetEditorialItem(int EditorialId);
        Task PutEditorials(int EditorialId, Editorial item);
        Task DeleteEditorials(int EditorialId);
    }
}
