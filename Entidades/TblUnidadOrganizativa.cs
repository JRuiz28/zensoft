//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblUnidadOrganizativa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblUnidadOrganizativa()
        {
            this.TblDependenciaOrganizativa = new HashSet<TblDependenciaOrganizativa>();
            this.TblDependenciaOrganizativa1 = new HashSet<TblDependenciaOrganizativa>();
            this.TblEmpleado = new HashSet<TblEmpleado>();
            this.TblTraslado = new HashSet<TblTraslado>();
            this.TblTraslado1 = new HashSet<TblTraslado>();
        }
    
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public decimal latitud { get; set; }
        public decimal logitud { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblDependenciaOrganizativa> TblDependenciaOrganizativa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblDependenciaOrganizativa> TblDependenciaOrganizativa1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblEmpleado> TblEmpleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblTraslado> TblTraslado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblTraslado> TblTraslado1 { get; set; }
    }
}