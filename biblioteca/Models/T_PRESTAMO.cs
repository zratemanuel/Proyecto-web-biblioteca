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
    
    public partial class T_PRESTAMO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_PRESTAMO()
        {
            this.T_COPIA = new HashSet<T_COPIA>();
        }
    
        public int idPrestamo { get; set; }
        public System.DateTime inicio { get; set; }
        public System.DateTime fin { get; set; }
        public int lector { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_COPIA> T_COPIA { get; set; }
        public virtual T_LECTOR T_LECTOR { get; set; }
    }
}
