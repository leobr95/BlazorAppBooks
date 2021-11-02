using BlazorAppBooks.Models;
using BlazorAppBooks.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppBooks.Pages
{
    public class ListaBooksBase : ComponentBase
    {
        [Inject]
        public IServicioBooks ServicioBooks { get; set; }
        public IEnumerable<Book> Books{ get; set;}
        
        protected override async Task OnInitializedAsync()
        {
            Books = (await ServicioBooks.GetBooks()).ToList();
        }


    }
}
