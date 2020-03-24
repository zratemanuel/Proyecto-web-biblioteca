using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace biblioteca.Models.ViewModels
{
    public class ListBooksViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public int Anio { get; set; }
        public string Tipo { get; set; }
        public string Autor { get; set; }
    }
}