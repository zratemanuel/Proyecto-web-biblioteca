using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace biblioteca.Models.ViewModels
{
    public class CreateBookViewModel
    {
        public string Titulo { get; set; }
        public int Tipo { get; set; }
        public string Editorial { get; set; }
        public int Anio { get; set; }
        public int Autor { get; set; }

    }
}