using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppBooks.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Titulo { get; set; }
        public int Año { get; set; }
        public int NumeroPagina { get; set; }
        public string Genero { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }

    }
}
