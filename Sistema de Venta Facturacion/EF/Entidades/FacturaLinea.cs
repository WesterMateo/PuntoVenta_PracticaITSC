namespace Sistema_de_Venta_Facturacion.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacturaLinea")]
    public partial class FacturaLinea
    {
        [Key]
        public int ID_FacturaLinea { get; set; }

        public int ID_Factura { get; set; }

        public int ID_Articulo { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal TotalPrecio{
            get
            {
                return Precio * Cantidad;
            }
        }
    }
}
