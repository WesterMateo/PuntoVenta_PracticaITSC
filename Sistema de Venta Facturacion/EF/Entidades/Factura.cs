namespace Sistema_de_Venta_Facturacion.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factura")]
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        [Key]
        public int ID_Factura { get; set; }

        public int ID_Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Fecha { get; set; }
        public bool Despachado { get; set; }
        public string Despachador { get; set; }
        public decimal ImporteFactura { get; set; }
        public decimal Cambio { get; set; }
        public string Cliente
        {
            get
            {
                return Usuario.Usuario1;
            }
        }
        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FacturaLinea> FacturaLinea { get; set; }
    }
}
