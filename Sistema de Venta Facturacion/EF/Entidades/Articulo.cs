namespace Sistema_de_Venta_Facturacion.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Articulo")]
    public partial class Articulo
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Articulo()
        //{
        //    FacturaLinea = new HashSet<FacturaLinea>();
        //}

        [Key]
        public int ID_Articulo { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public int Cantidad { get; set; }

        [Required]
        [StringLength(50)]
        public string Categoria { get; set; }

        public bool Activo { get; set; }
        public string Estado { 
            get
            {
                if (Cantidad < 1)
                {
                    return "No disponible";
                }
                else
                {
                    return "Disponible";
                }                    
            }
        }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<FacturaLinea> FacturaLinea { get; set; }
    }
}
