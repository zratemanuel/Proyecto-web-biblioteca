//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace biblioteca.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_LIBRO
    {
        public int id_libro { get; set; }
        public string titulo { get; set; }
        public int tipo { get; set; }
        public string editorial { get; set; }
        public int año { get; set; }
        public int autor { get; set; }
    
        public virtual T_AUTOR T_AUTOR { get; set; }
        public virtual T_TIPO T_TIPO { get; set; }
    }
}
