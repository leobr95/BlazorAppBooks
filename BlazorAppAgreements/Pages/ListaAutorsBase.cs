using BlazorAppBooks.Models;
using BlazorAppBooks.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppBooks.Pages
{
    public class ListaAutorsBase : ComponentBase
    {
        [Inject]
        public IServicioAutors ServicioAutors { get; set; }
        public IEnumerable<Autor> Autors{ get; set;}
        [Inject]
        public IServicioBooks ServicioBooks { get; set; }
        public IEnumerable<Book> Books { get; set; }
        [Inject]
        public IServicioBooks ServicioNegocios { get; set; }
        public IEnumerable<Negocio> Negocio { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Autors = (await ServicioAutors.GetAutors()).ToList();
        }


    }
}
