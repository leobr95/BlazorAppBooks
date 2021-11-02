using BlazorAppBooks.Models;
using BlazorAppBooks.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppBooks.Pages
{
    public class ListaNegociosBase : ComponentBase
    {
        [Inject]
        public IServicioNegocios ServicioNegocios { get; set; }
        public IEnumerable<Negocio> Negocios { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Negocios = (await ServicioNegocios.GetNegocios()).ToList();
        }


    }
}
