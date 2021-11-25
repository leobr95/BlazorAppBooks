using BlazorAppBooks.Models;
using BlazorAppBooks.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppBooks.Pages
{
    public class ListaEditorialsBase : ComponentBase
    {
        [Inject]
        public IServicioEditorials ServicioEditorials { get; set; }
        public IEnumerable<Editorial> Editorials{ get; set;}
        [Inject]
        public IServicioBooks ServicioBooks { get; set; }
        public IEnumerable<Book> Books { get; set; }
        [Inject]
        public IServicioBooks ServicioNegocios { get; set; }
        public IEnumerable<Negocio> Negocio { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Editorials = (await ServicioEditorials.GetEditorials()).ToList();
        }


    }
}
